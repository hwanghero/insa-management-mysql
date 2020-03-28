using project.user;
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
        // 레지스트리 연결 객체
        Registry rg = new Registry();

        static String staticid;

        public static void setid(String id)
        {
            staticid = id;
        }

        public static String getid()
        {
            return staticid;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = idbox.Text;
            String pw = pwbox.Text;

            int miss = db.get_pwmiss(id);

            // 아이디가 있는지?
            if (db.idcheck(id) == 1)
            {
                // 7일이 안지났는지?
                if (db.day_check(id) == 0)
                {
                    // 비밀번호 5회를 안틀렸는지?
                    if (miss < 5)
                    {
                        setid(id);
                        Console.WriteLine("관리자체크: " + admin_radio);
                        Console.WriteLine("return 체크: " + db.logincheck(id, pw));

                        // 아이디 비밀번호가 맞는지?
                        if (db.logincheck(id, pw) == 1 || db.logincheck(id, pw) == 2)
                        {
                            // 날짜 업데이트
                            db.day_update(id);
                            this.Hide();

                            if (db.logincheck(id, pw) == 1 && admin_radio.Checked)
                            {
                                MessageBox.Show("권한이 없습니다\n사용자 관리 프로그램으로 실행됩니다");
                            }
                            if (db.logincheck(id, pw) == 2 && admin_radio.Checked)
                            {
                                form_admin.admin_main admin_main = new form_admin.admin_main();
                                admin_main.ShowDialog();
                            }
                            else 
                            {
                                main main = new main();
                                main.ShowDialog();
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("아이디, 비밀번호가 틀립니다. (남은 횟수: " + (5 - miss) + ")");
                            db.misscheck(id);
                        }
                    }
                    else
                    {
                        MessageBox.Show("비밀번호 5회 틀려서 아이디가 잠겨졌습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("장기간 미사용으로 아이디가 잠겨졌습니다.");
                }
            }
            else
            {
                MessageBox.Show("없는 아이디입니다.");
            }

            // 해쉬 : project.user.Hash hash = new project.user.Hash();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.connectionOpen();

            Console.WriteLine(rg.Get_ID_Registry());
            Console.WriteLine(rg.Get_Save_Registry());
            if (rg.Get_Save_Registry().Equals("True"))
            {
                checkBox1.Checked = true;
                idbox.Text = rg.Get_ID_Registry();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            String id = idbox.Text;
            if (checkBox1.Checked == true)
            {
                // 공백상태에서 저장을 안해주면 폼을 킬때마다 공백으로 저장이됨
                if (rg.Get_ID_Registry().Equals(""))
                    rg.Set_ID_Registry(id);

                rg.Set_Savecheck_Registry(true);
            }
            else
            {
                rg.Set_Savecheck_Registry(false);
                rg.Set_ID_Registry("");
            }
        }

        private void idbox_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                rg.Set_ID_Registry(idbox.Text);
        }
    }
}
