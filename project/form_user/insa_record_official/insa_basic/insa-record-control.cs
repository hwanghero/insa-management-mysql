using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class insacontrol : Form
    {
        // 입력,수정,삭제 외 클래스
        user.insa_record_official.insa_basic_main insa_db_main = new user.insa_record_official.insa_basic_main();
        // 입력
        user.insa_record_official.insa_basic_insert insa_db_insert = new user.insa_record_official.insa_basic_insert();
        // 메인 폼 불러오기 (사이즈)
        user.form_user_setting form_s = new user.form_user_setting();
        // 조회 데이터베이스
        user.insa_record_official.insa_basic_list insa_list_db = new user.insa_record_official.insa_basic_list();
        // 수정 데이터베이스
        user.insa_record_official.insa_basic_update insa_update_db = new user.insa_record_official.insa_basic_update();
        // 삭제 데이터베이스
        user.insa_record_official.insa_basic_delete insa_delete_db = new user.insa_record_official.insa_basic_delete();

        String click_mode = "";

        // 불러온 유저 리스트 저장 할 변수
        //List<String[]> rows_data = new List<String[]>();
        //DataTable table = new DataTable();

        public insacontrol()
        {
            InitializeComponent();
        }

        // 어댑터로 불러오기

        //public void a()
        //{
        //    dataGridView1.DataSource = insa_list_db.empno_get(checkedListBox1);
        //    if (checkedListBox1.Items.Count != 0)
        //    {
        //        for (int x = 0; x < checkedListBox1.Items.Count; x++)
        //        {
        //            dataGridView1.Columns[x].HeaderText = checkedListBox1.Items[x].ToString();
        //        }
        //    }
        //}

        // 그냥 쿼리로 불러오기

        //public void all()
        //{
        //    rows_data = insa_list_db.empno_list();
        //    int user_count = insa_list_db.empno_list_count();
        //    DataTable table = new DataTable();
        //    if (checkedListBox1.Items.Count != 0)
        //    {
        //        for (int x = 0; x < checkedListBox1.Items.Count; x++)
        //        {
        //            table.Columns.Add(checkedListBox1.Items[x].ToString(), typeof(string));
        //        }
        //    }
        //    // 개비효율적.
        //    foreach (String[] k in rows_data)
        //    {
        //            table.Rows.Add(k);
        //    }
        //    //table.Rows.Add(k[0], k[1], k[2], k[3], k[4], k[5], k[6], k[7], k[8], k[9], k[10], k[11], k[12], k[13], k[14], k[15], k[16], k[17], k[18], k[19], k[20], k[21], k[22], k[23], k[24], k[25], k[26], k[27],
        //    //    k[28], k[29], k[30], k[31], k[32], k[33], k[34], k[35], k[36], k[37], k[38], k[39], k[40]);

        //    dataGridView1.DataSource = table;
        //}

        private void insacontrol_Load(object sender, EventArgs e)
        {
            insa_list_db.connectionOpen();
            insa_db_main.connectionOpen();
            insa_db_insert.connectionOpen();
            insa_update_db.connectionOpen();
            insa_delete_db.connectionOpen();

            form_s.setting(this);
            apply_b.Enabled = false;
            cancel_b.Enabled = false;
            datagridview();
        }

        public void datagridview()
        {
            DataTable table = new DataTable();

            // column을 추가합니다.
            table.Columns.Add("사원번호", typeof(string));
            table.Columns.Add("이름", typeof(string));

            List<string[]> user_data = insa_list_db.empno_list();
            foreach (string[] a in user_data)
            {
                table.Rows.Add(a[0], a[1]);
            }
            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            dataGridView1.DataSource = table;
        }

        private void insert_b_Click(object sender, EventArgs e)
        {
            click_mode = "insert";
            applyEnabled(true);
            buttonEnabled(false);
        }

        private void update_b_Click(object sender, EventArgs e)
        {
            click_mode = "update";
            applyEnabled(true);
            buttonEnabled(false);
            
        }

        private void delete_b_Click(object sender, EventArgs e)
        {
            click_mode = "delete";
            applyEnabled(true);
            buttonEnabled(false);
            textbox_enable(false);
        }

        private void apply_b_Click(object sender, EventArgs e)
        {
            String nowtime = DateTime.Now.ToString("yyyyMMdd");
            String getid = login.getid(); // 사용자 아이디 ( 이름은 추가해야할듯 )

            // 입력할경우 
            if (click_mode.Equals("insert"))
            {
                if (insa_db_main.empno_check(e_no_box.Text) == 0)
                {
                    // 자료처리구분	datasys2 varchar(1),	"A" , "U"

                    /*
                     * 
                     *  안에 데이터값 체크해서 제대로 값 입력되게 설정
                     *  1. textbox keypress로 1차로 설정
                     *  2. 정규식으로 2차로 설정
                     * 
                     */

                    // 사원넘버 체크
                    Regex emp_check = new Regex(@"^[+-]?\d*$");
                    // 주민등록번호 정규식
                    Regex rrn_check_1 = new Regex(@"^(?:[0-9]{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[1,2][0-9]|3[0,1]))-[1-4][0-9]{6}$");
                    // 휴대폰 체크
                    Regex phone_Check = new Regex(@"^01[01678]-[0-9]{4}-[0-9]{4}$");
                    // 한국이름
                    Regex korea_name_check = new Regex(@"[가-힣]{2,5}");

                    //if (!rrn_check_1.IsMatch(rrn_box.Text) || !phone_Check.IsMatch(phone_box.Text) || !korea_name_check.IsMatch(kor_name_box.Text) || !emp_check.IsMatch(e_no_box.Text))
                    //{
                    //    Console.WriteLine("안맞죠?");
                    //    return;
                    //}

                    if (string.IsNullOrWhiteSpace(newbie_month_box.Text))
                    {
                        MessageBox.Show("안 넣은값이 있습니다.");
                        return;
                    }

                    int nmbox = Convert.ToInt32(newbie_month_box.Text);
                    if (insa_db_insert.thrm_bas_add(e_no_box.Text, rrn_box.Text, kor_name_box.Text, chn_name_box.Text, eng_name_box.Text,
                        sexxbox.Text, zip_box.Text, address_box.Text, residence_box.Text, phone_box.Text, home_box.Text, email1_box.Text,
                        mil_ok_box.Text, mil_catagory_box.Text, mil_rank_box.Text, marry_box.Text, bank_name_box.Text, bank_master_box.Text,
                        bank_number_box.Text, bank_name_box2.Text, bank_master_box2.Text, bank_number_box2.Text, contract_box.Text,
                        newbie_check_box.Text, nmbox, slave_start.Text, slave_end.Text,
                        join_box.Text, goodbye_box.Text, "", "", state_box.Text, identity_box.Text, rank_box.Text, dut_box.Text,
                        department_box.Text, note_box.Text, now_rank_box.Text, now_spot_box.Text, now_department_box.Text,
                        now_newbie_box.Text, nowtime, "A", getid) == 0)
                    {
                        MessageBox.Show("입력이 완료되었습니다.");
                        datagridview();
                    }
                    else
                    {
                        MessageBox.Show("문제가 생겨 입력을 실패하였습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("이미 있는 사원번호 입니다.");
                }
            }
            else if (click_mode.Equals("update"))
            {
                if (insa_db_main.empno_check(e_no_box.Text) == 1)
                {
                    int nmbox = Convert.ToInt32(newbie_month_box.Text);
                    if (insa_update_db.thrm_bas_update(e_no_box.Text, rrn_box.Text, kor_name_box.Text, chn_name_box.Text, eng_name_box.Text,
                        sexxbox.Text, zip_box.Text, address_box.Text, residence_box.Text, phone_box.Text, home_box.Text, email1_box.Text,
                        mil_ok_box.Text, mil_catagory_box.Text, mil_rank_box.Text, marry_box.Text, bank_name_box.Text, bank_master_box.Text,
                        bank_number_box.Text, bank_name_box2.Text, bank_master_box2.Text, bank_number_box2.Text, contract_box.Text,
                        newbie_check_box.Text, nmbox, slave_start.Text, slave_end.Text,
                        join_box.Text, goodbye_box.Text, "", "", state_box.Text, identity_box.Text, rank_box.Text, dut_box.Text,
                        department_box.Text, note_box.Text, now_rank_box.Text, now_spot_box.Text, now_department_box.Text,
                        now_newbie_box.Text, nowtime, "A", getid) == 0)
                    {
                        MessageBox.Show("입력이 완료되었습니다.");
                        datagridview();
                    }
                    else
                    {
                        MessageBox.Show("문제가 생겨 입력을 실패하였습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("없는 사원번호입니다.");
                }
            }
            else if (click_mode.Equals("delete"))
            {
                if (insa_db_main.empno_check(e_no_box.Text) == 1)
                {
                    if (insa_delete_db.insa_delete(e_no_box.Text) == 0)
                    {
                        MessageBox.Show("삭제가 완료되었습니다.");
                        datagridview();
                    }
                }
                else
                {
                    MessageBox.Show("없는 사원번호입니다.");
                }
            }

            applyEnabled(false);
            buttonEnabled(true);
            textbox_Reset();
            textbox_enable(true);
        }

        private void cancel_b_Click(object sender, EventArgs e)
        {
            applyEnabled(false);
            buttonEnabled(true);
            textbox_Reset();
        }

        private void e_no_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void applyEnabled(Boolean check)
        {
            if (check == false)
            {
                apply_b.Enabled = false;
                cancel_b.Enabled = false;
            }
            else
            {
                apply_b.Enabled = true;
                cancel_b.Enabled = true;
            }
        }

        public void buttonEnabled(Boolean check)
        {
            if (check == false)
            {
                insert_b.Enabled = false;
                update_b.Enabled = false;
                delete_b.Enabled = false;
            }
            else
            {
                insert_b.Enabled = true;
                update_b.Enabled = true;
                delete_b.Enabled = true;
            }
        }

        public void textbox_Reset()
        {
            note_box.Text = "";
            foreach (Control c in groupBox1.Controls)
            {
                TextBox tb = c as TextBox;
                MaskedTextBox tb_2 = c as MaskedTextBox;
                ComboBox cb = c as ComboBox;
                if (tb != null) tb.Text = "";
                if (tb_2 != null) tb_2.Text = "";
                if (cb != null) cb.SelectedItem = null;
            }
            foreach (Control c in groupBox3.Controls)
            {
                TextBox tb = c as TextBox;
                MaskedTextBox tb_2 = c as MaskedTextBox;
                if (tb != null) tb.Text = "";
                if (tb_2 != null) tb_2.Text = "";
            }
            foreach (Control c in groupBox4.Controls)
            {
                TextBox tb = c as TextBox;
                MaskedTextBox tb_2 = c as MaskedTextBox;
                ComboBox cb = c as ComboBox;
                DateTimePicker dp = c as DateTimePicker;
                if (tb != null) tb.Text = "";
                if (tb_2 != null) tb_2.Text = "";
                if (cb != null) cb.SelectedItem = null;
                if (dp != null) dp.Value = DateTime.Now;
            }
            foreach (Control c in mil_group.Controls)
            {
                ComboBox cb = c as ComboBox;
                if (cb != null) cb.SelectedItem = null;
            }
        }

        public void textbox_enable(Boolean check)
        {
            note_box.Enabled = check;
            foreach (Control c in groupBox1.Controls)
            {
                TextBox tb = c as TextBox;
                MaskedTextBox tb_2 = c as MaskedTextBox;
                ComboBox cb = c as ComboBox;
                if (tb != null) tb.Enabled = check;
                if (tb_2 != null) tb_2.Enabled = check;
                if (cb != null) cb.Enabled = check;
            }
            foreach (Control c in groupBox3.Controls)
            {
                TextBox tb = c as TextBox;
                MaskedTextBox tb_2 = c as MaskedTextBox;
                if (tb != null) tb.Enabled = check;
                if (tb_2 != null) tb_2.Enabled = check;
            }
            foreach (Control c in groupBox4.Controls)
            {
                TextBox tb = c as TextBox;
                MaskedTextBox tb_2 = c as MaskedTextBox;
                ComboBox cb = c as ComboBox;
                DateTimePicker dp = c as DateTimePicker;
                if (tb != null) tb.Enabled = check;
                if (tb_2 != null) tb_2.Enabled = check;
                if (cb != null) cb.Enabled = check;
                if (dp != null) dp.Enabled = check;
            }
            foreach (Control c in mil_group.Controls)
            {
                ComboBox cb = c as ComboBox;
                if (cb != null) cb.Enabled = check;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String empno = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<string> user_data = insa_update_db.insa_basic_getdata(empno);
            if (click_mode.Equals("delete"))
            {
                e_no_box.Text = empno;
            }

            if (click_mode.Equals("update"))
            {
                if (user_data != null)
                {
                    e_no_box.Text = user_data[0];
                    rrn_box.Text = user_data[1];
                    kor_name_box.Text = user_data[2];
                    chn_name_box.Text = user_data[3];
                    eng_name_box.Text = user_data[4];
                    sexxbox.Text = user_data[5];
                    zip_box.Text = user_data[6];
                    address_box.Text = user_data[7];
                    residence_box.Text = user_data[8];
                    phone_box.Text = user_data[9];
                    home_box.Text = user_data[10];
                    email1_box.Text = user_data[11];
                    mil_ok_box.Text = user_data[12];
                    mil_catagory_box.Text = user_data[13];
                    mil_rank_box.Text = user_data[14];
                    marry_box.Text = user_data[15];
                    bank_name_box.Text = user_data[16];
                    bank_master_box.Text = user_data[17];
                    bank_number_box.Text = user_data[18];
                    bank_name_box2.Text = user_data[19];
                    bank_master_box2.Text = user_data[20];
                    bank_number_box2.Text = user_data[21];
                    contract_box.Text = user_data[22];
                    newbie_check_box.Text = user_data[23];
                    newbie_month_box.Text = user_data[24];
                    // datatime으로 넣어야함. 밑에껏들
                    //slave_start.Text = user_data[25];
                    //slave_end.Text = user_data[26];
                    //join_box.Text = user_data[27];
                    //goodbye_box.Text = user_data[28];
                    //29
                    //30
                    state_box.Text = user_data[31];
                    identity_box.Text = user_data[32];
                    rank_box.Text = user_data[33];
                    dut_box.Text = user_data[34];
                    department_box.Text = user_data[35];
                    note_box.Text = user_data[36];
                    //now_rank_box.Text = user_data[37];
                    //now_spot_box.Text = user_data[38];
                    //now_department_box.Text = user_data[39];
                    //now_newbie_box.Text = user_data[40];
                }
            }
        }
    }
}
