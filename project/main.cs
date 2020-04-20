using project.form_admin;
using project.form_user;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace project
{
    public partial class main : Form
    {
        // 폼 저장 변수
        Form[] form_name = new Form[4];
        int form_count = 0;

        user.form_user_setting form_s = new user.form_user_setting();
        // 인사기록관리
        insacontrol insacontrol = new insacontrol(); // 인사기본사항
        // 비밀번호 변경
        password_change password_chagne = new password_change();
        // 유저 정보 폼
        admin_user_info admin_user_info = new admin_user_info();
        // 유저 추가
        admin_user_add admin_user_add = new admin_user_add();

        form_user.form_control form_control = new form_control();

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
                form_control = new form_control(insacontrol);

                insacontrol.Show();
                form_control.Show();
            }
            if (e.Node.Text.Equals("비밀번호 변경"))
            {
                password_chagne.Show();
            }
            if (e.Node.Text.Equals("사용자 및 관리자 추가"))
            {
                admin_user_add.Show();
            }

            if (e.Node.Text.Equals("사용자 조회 및 수정"))
            {
                admin_user_info.Show();
            }

            form_control.TopLevel = false;
            this.Controls.Add(form_control);
            form_control.Parent = this.contorl_panel;
            form_control.ControlBox = false;

            form_user.form_control.set_mode(e.Node.Text);
            this.Text = "인사관리프로그램 - " + e.Node.Text;
        }

        private void main_Load(object sender, EventArgs e)
        {
            form_s.setSize(panel1.Size);

            // 인사기록관리
            main_add(insacontrol);
            // 비번 변경
            main_add(password_chagne);
            main_add(admin_user_info);
            main_add(admin_user_add);

            if (login.get_user_level() == 2)
            {
                TreeNode newNode = new TreeNode("사용자 관리 (관리자)");
                treeView1.Nodes.Add("사용자 관리", "사용자 관리 (관리자)");
                treeView1.Nodes.Find("사용자 관리", true)[0].Nodes.Add("사용자 승인관리", "사용자 승인관리");
                treeView1.Nodes.Find("사용자 관리", true)[0].Nodes.Add("사용자 및 관리자 추가", "사용자 및 관리자 추가");
                treeView1.Nodes.Find("사용자 관리", true)[0].Nodes.Add("사용자 조회 및 수정", "사용자 조회 및 수정");
            }
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
