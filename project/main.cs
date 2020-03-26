using project.form_user;
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
    public partial class main : Form
    {
        // 폼 저장 변수
        int form_count = 0;

        // 인사기초정보
        insainfo insainfo = new insainfo();
        // 인사기록관리
        insacontrol insacontrol = new insacontrol();
        // 비밀번호 변경
        password_change password_chagne = new password_change();

        public main()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine(e.Node.Text);
            // 폼이름을 넣어야함
            String[] form_name = new String[form_count];
            for (int i = 0; i < form_name.Length; i++)
            {
                Console.WriteLine("form load: " + form_name[i].ToString());
            }

            insacontrol.Hide();
            insainfo.Hide();
            password_chagne.Hide();
            
            if (e.Node.Text.Equals("인사기초정보"))
            {
                insainfo.Show();
            }
            if (e.Node.Text.Equals("인사기록관리"))
            {
                insacontrol.Show();
            }
            if(e.Node.Text.Equals("비밀번호 변경"))
            {
                password_chagne.Show();
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            main_add(insainfo);
            main_add(insacontrol);
            main_add(password_chagne);
        }

        public void main_add(Form addform)
        {
            addform.TopLevel = false;
            this.Controls.Add(addform);
            addform.Parent = this.panel1;
            addform.ControlBox = false;
            form_count++;
        }
    }
}
