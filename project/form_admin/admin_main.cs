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
    public partial class admin_main : Form
    {
        // 폼 저장 변수
        Form[] form_name = new Form[10];
        int form_count = 0;

        // 유저 정보 폼
        admin_user_info admin_user_info = new admin_user_info();
        // 유저 추가
        admin_user_add admin_user_add = new admin_user_add();

        public admin_main()
        {
            InitializeComponent();
        }

        private void admin_main_Load(object sender, EventArgs e)
        {
            main_add(admin_user_info);
            main_add(admin_user_add);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < form_name.Length - 1; i++)
                form_hide(form_name[i]);

            if (e.Node.Text.Equals("사용자 및 관리자 추가"))
            {
                admin_user_add.Show();
            }

            if (e.Node.Text.Equals("사용자 조회 및 수정"))
            {
                admin_user_info.Show();
            }
        }
    }
}
