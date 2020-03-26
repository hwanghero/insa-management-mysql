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
        Form[] form_name = new Form[10];
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
            for (int i=0; i < form_name.Length-1; i++)
                form_hide(form_name[i]);
   
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

        // 폼 추가
        public void main_add(Form addform)
        {
            addform.TopLevel = false;
            this.Controls.Add(addform);
            addform.Parent = this.panel1;
            addform.ControlBox = false;
            form_name[form_count] = addform;
            form_count++;
            Array.Resize(ref form_name, form_count+1);
        }

        // 폼 숨기기
        public void form_hide(Form hideform)
        {
            hideform.Hide();
        }
    }
}
