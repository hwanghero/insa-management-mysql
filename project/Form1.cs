using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        // 데이터베이스 연결 객체
        database db = new database();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = idbox.Text;
            String pw = pwbox.Text;
            
            if(db.logincheck(id, pw) == 1)
            {
                this.Hide();
               
                MessageBox.Show("로그인이 되었습니다.");
                main main = new main();
                main.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("아이디, 비밀번호가 틀립니다.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.connectionDB();
        }
    }
}
