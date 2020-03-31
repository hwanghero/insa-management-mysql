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
        DataTable table = new DataTable();
        String[,] rows_data;
        admin.user_list user_list = new admin.user_list();

        public admin_user_info()
        {
            InitializeComponent();
        }

        private void admin_user_info_Load(object sender, EventArgs e)
        {
            user_list.connectionOpen();

            int user_count = user_list.User_list_count();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();  // 각 열의 데이터에 맞게 자동으로 사이즈를 조절

            // column을 추가합니다.
            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("비밀번호", typeof(string));
            table.Columns.Add("비밀번호 틀린 횟수", typeof(string));
            table.Columns.Add("접속 날짜", typeof(string));
            table.Columns.Add("권한", typeof(string));

            // 각각의 행에 내용을 입력합니다.
            rows_data = new string[user_count, 5];
            rows_data = user_list.User_list();

            for (int i=0; i< user_count; i++)
            {
                table.Rows.Add(rows_data[i, 0], rows_data[i, 1], rows_data[i, 2], rows_data[i, 3], rows_data[i, 4]);
            }

            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            dataGridView1.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // 수정 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            // 전체 셀 불러오는거임
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                    return;

                string value = row.Cells[0].Value.ToString();
                Console.WriteLine(value);
            }
        }
        // 취소 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_ControlAdded(object sender, ControlEventArgs e)
        {
            // 셀 추가 됐을경우.
        }
    }
}
