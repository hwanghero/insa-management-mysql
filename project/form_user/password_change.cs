using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.form_user
{
    public partial class password_change : Form
    {
        server.password_changecs c_pw_class = new server.password_changecs();

        public password_change()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String now_pw = this.now_pw.Text;
            String c_pw = this.c_pw.Text;
            String c_pw_check = this.c_pw_check.Text;

            if (c_pw.Equals(c_pw_check))
            {
                if (c_pw_class.user_pw_change(login.getid(), now_pw, c_pw) == 1)
                {
                    MessageBox.Show("비밀번호 변경완료");
                }
                else
                {
                    MessageBox.Show("현재 비밀번호가 다릅니다.");
                }
            }
            else
            {
                MessageBox.Show("수정할 비밀번호가 서로 일치하지 않습니다.");
            }
        }

        private void password_change_Load(object sender, EventArgs e)
        {
            c_pw_class.connectionOpen();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
