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
        // 인사기초정보
        insainfo insainfo = new insainfo();
        // 인사기록관리
        insacontrol insacontrol = new insacontrol();

        public main()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text);

            insacontrol.Hide();
            insainfo.Hide();

            if (e.Node.Text.Equals("인사기초정보"))
            {
                insainfo.Show();
            }
            if (e.Node.Text.Equals("인사기록관리"))
            {
                insacontrol.Show();
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            insainfo.TopLevel = false;
            insacontrol.TopLevel = false;

            this.Controls.Add(insainfo);
            this.Controls.Add(insacontrol);

            insacontrol.Parent = this.panel1;
            insainfo.Parent = this.panel1;

            insainfo.Text = "";
            insacontrol.Text = "";

            insacontrol.ControlBox = false;
            insainfo.ControlBox = false;

        }
    }
}
