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

namespace project.form_user.insa_record_official.insa_basic
{
    public partial class insa_basic_insert : Form
    {
        // 입력,수정,삭제 외 클래스
        user.insa_record_official.insa_basic_main insa_db_main = new user.insa_record_official.insa_basic_main();
        // 입력
        user.insa_record_official.insa_basic_insert insa_db_insert = new user.insa_record_official.insa_basic_insert();

        // 확인,취소 눌렀을경우 확인
        String click_mode = "";

        public insa_basic_insert()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            click_mode = "ok";
            ok_button.Enabled = false;
            cancel_button.Enabled = true;
            apply_button.Enabled = true;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            click_mode = "no";
            cancel_button.Enabled = false;
            ok_button.Enabled = true;
            apply_button.Enabled = true;
        }

        private void apply_box_Click(object sender, EventArgs e)
        {
            if (click_mode.Equals("ok"))
            {
                if (insa_db_main.empno_check(e_no_box.Text) == 0)
                {
                    String nowtime = DateTime.Now.ToString("yyyyMMdd");
                    String getid = Form1.getid(); // 사용자 아이디 ( 이름은 추가해야할듯 )
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
                    insa_db_insert.thrm_bas_add(e_no_box.Text, rrn_box.Text, kor_name_box.Text, chn_name_box.Text, eng_name_box.Text,
                        sexxbox.Text, zip_box.Text, address_box.Text, residence_box.Text, phone_box.Text, home_box.Text, email1_box.Text,
                        mil_ok_box.Text, mil_catagory_box.Text, mil_rank_box.Text, marry_box.Text, bank_name_box.Text, bank_master_box.Text,
                        bank_number_box.Text, bank_name_box2.Text, bank_master_box2.Text, bank_number_box2.Text, contract_box.Text,
                        newbie_check_box.Text, nmbox, slave_start.Text, slave_end.Text,
                        join_box.Text, goodbye_box.Text, "", "", state_box.Text, identity_box.Text, rank_box.Text, dut_box.Text,
                        department_box.Text, note_box.Text, now_rank_box.Text, now_spot_box.Text, now_department_box.Text,
                        now_newbie_box.Text, nowtime, "A", getid);

                    Console.WriteLine("o");
                }
                else
                {
                    MessageBox.Show("이미 있는 사원번호 입니다.");
                }
            }
            else if (click_mode.Equals("no"))
            {
                Console.WriteLine("no");
            }

        }

        private void insa_basic_insert_Load(object sender, EventArgs e)
        {
            insa_db_main.connectionOpen();
            insa_db_insert.connectionOpen();
            apply_button.Enabled = false;
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
    }
}
