using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.form_admin
{
    public partial class admin_user_info : Form
    {
        // 데이터베이스에서 불러옴 유저 리스트
        admin.user_list user_list = new admin.user_list();
        admin.user_update user_update = new admin.user_update();

        // 그리드뷰 테이블
        DataTable table = new DataTable();

        // 불러온 유저 리스트 저장 할 변수
        List<String[]> rows_data = new List<String[]>();
        // 수정하기 위해 임시 저장용 리스트
        List<String[]> rows_temp_data = new List<String[]>();

        public admin_user_info()
        {
            InitializeComponent();
        }

        private void admin_user_info_Load(object sender, EventArgs e)
        {
            user_update.connectionOpen();
            user_list.connectionOpen();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();  // 각 열의 데이터에 맞게 자동으로 사이즈를 조절
            dataGridView1.AllowUserToAddRows = false;

            // column을 추가합니다.
            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("비밀번호", typeof(string));
            table.Columns.Add("비밀번호 틀린 횟수", typeof(string));
            table.Columns.Add("접속 날짜", typeof(string));
            table.Columns.Add("권한", typeof(string));

            table.Columns["아이디"].ReadOnly = true;
            table.Columns["비밀번호"].ReadOnly = true;
            table.Columns["비밀번호 틀린 횟수"].ReadOnly = true;
            table.Columns["접속 날짜"].ReadOnly = true;

            table_add();
        }

        public void table_add()
        {
            rows_data = user_list.User_list();
            // 각각의 행에 내용을 입력합니다.
            foreach (String[] k in rows_data)
            {
                table.Rows.Add(k[0], k[1], k[2], k[3], k[4]);
            }
            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            dataGridView1.DataSource = table;
        }

        // 수정 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            int clear_check = 0;
            rows_temp_data.Clear();

            // 전체 셀 불러오는거임
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                    return;

                string cell_id = row.Cells[0].Value.ToString();
                string cell_pw = row.Cells[1].Value.ToString();
                string cell_pw_miss = row.Cells[2].Value.ToString();
                string cell_joinday= row.Cells[3].Value.ToString();
                string cell_level = row.Cells[4].Value.ToString();

                if (String.IsNullOrWhiteSpace(cell_id) && String.IsNullOrWhiteSpace(cell_pw) && String.IsNullOrWhiteSpace(cell_pw_miss) && String.IsNullOrWhiteSpace(cell_joinday) && String.IsNullOrWhiteSpace(cell_id) && String.IsNullOrWhiteSpace(cell_level))
                {
                    MessageBox.Show((row.Index+1)+ "번째의 사용자 정보를 모두 입력해주세요");
                    return;
                }

                if(!cell_level.Equals("관리자") && !cell_level.Equals("사용자"))
                {
                    MessageBox.Show((row.Index + 1) + "번째에 잘못된 권한을 입력하였습니다.\n관리자 및 사용자만 입력 가능합니다.");
                    return;
                }
                else
                {
                    String[] temp_data = new String[5];
                    temp_data[0] = cell_id;
                    temp_data[1] = cell_pw;
                    temp_data[2] = cell_pw_miss;
                    temp_data[3] = cell_joinday;
                    temp_data[4] = cell_level;
                    rows_temp_data.Add(temp_data);
                    clear_check = 1;
                }
                Console.WriteLine("--------\n" + cell_id +"\n"+ cell_pw + "\n" + cell_pw_miss + "\n" + cell_joinday + "\n" + cell_level + "\n--------");
            }
            Console.WriteLine(clear_check);
            if(clear_check == 1)
            {
                rows_data.Clear();
                // 이렇게 해주는 이유는 취소 버튼을 위해서임
                rows_data = rows_temp_data;

                // 한번 지우고 다시 불러와서 저장해야지 class에 값이 들어가네
                table.Rows.Clear();
                user_update.User_update(rows_temp_data);
                table_add();
                MessageBox.Show("수정이 성공적으로 완료되었습니다.");
            }
        }
        // 취소 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            table_add();
            MessageBox.Show("수정하기 전의 상태로 취소하였습니다.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 선택셀
            // dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "아이디" || dataGridView1.Columns[e.ColumnIndex].Name == "비밀번호" ||
                dataGridView1.Columns[e.ColumnIndex].Name == "비밀번호 틀린 횟수" || dataGridView1.Columns[e.ColumnIndex].Name == "접속 날짜")
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
