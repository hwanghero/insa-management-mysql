﻿using project.user;
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
                main main = new main();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("아이디, 비밀번호가 틀립니다.");
                db.misscheck(id);
                
            }
            // 해쉬 : project.user.Hash hash = new project.user.Hash();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(rg.Get_Save_Registry().Equals("True"))
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
