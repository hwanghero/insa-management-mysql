using project.form_user;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace project
{
    public partial class main : Form
    {
        // 폼 저장 변수
        Form[] form_name = new Form[10];
        int form_count = 0;

        user.form_user_setting form_s = new user.form_user_setting();

        // 인사기록관리
        insacontrol insacontrol = new insacontrol(); // 인사기본사항

        // 비밀번호 변경
        password_change password_chagne = new password_change();

        public main()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < form_name.Length - 1; i++)
                form_hide(form_name[i]);

            // 인사기록관리
            if (e.Node.Text.Equals("인사기본사항"))
            {
                insacontrol.Show();
            }
            if (e.Node.Text.Equals("비밀번호 변경"))
            {
                password_chagne.Show();
            }
            this.Text = "인사관리프로그램 - " + e.Node.Text;
        }

        private void main_Load(object sender, EventArgs e)
        {
            form_s.setSize(panel1.Size);

            // 인사기록관리
            main_add(insacontrol);
            // 비번 변경
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
            Array.Resize(ref form_name, form_count + 1);
        }

        // 폼 숨기기
        public void form_hide(Form hideform)
        {
            hideform.Hide();
        }
    }
}
