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
    public partial class admin_user_add : Form
    {
        // 유저 추가 클래스 추가
        admin.user_add user_add = new admin.user_add();
        // 해쉬 클래스 추가
        user.Hash hash2 = new user.Hash();
        
        String level = "";

        public admin_user_add()
        {
            InitializeComponent();
        }

        private void admin_user_add_Load(object sender, EventArgs e)
        {
            user_add.connectionOpen();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            String add_id = idbox.Text;
            String add_pw = hash2.EncryptSHA512(pwbox.Text);
            String add_level = levelbox.Text;

            Console.WriteLine(add_id);
            Console.WriteLine(add_pw);
            Console.WriteLine(add_level);
            Console.WriteLine(level);

            if (user_add.admin_user_add(add_id, add_pw, level) == 1)
            {
                Console.WriteLine("성공적으로 사용자를 추가하였습니다.");
            }
            else
            {
                Console.WriteLine("중복된 아이디여서 추가에 실패하였습니다.");
            }
        }

        private void levelbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String curItem = levelbox.SelectedItem.ToString();
            if (curItem.Equals("사용자"))
            {
                level = "user";
            }
            if (curItem.Equals("관리자"))
            {
                level = "admin";
            }
        }
    }
}
