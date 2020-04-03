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
    public partial class insacontrol : Form
    {
        // 입력 폼
        form_user.insa_record_official.insa_basic.insa_basic_insert insa_basic = new form_user.insa_record_official.insa_basic.insa_basic_insert();
        // 수정 폼
        form_user.insa_record_official.insa_basic.insa_basic_update insa_update = new form_user.insa_record_official.insa_basic.insa_basic_update();
        // 삭제 폼
        form_user.insa_record_official.insa_basic.insa_basic_delete insa_delete = new form_user.insa_record_official.insa_basic.insa_basic_delete();

        public insacontrol()
        {
            InitializeComponent();
        }

        private void insacontrol_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 입력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisposeCheck(insa_basic, 1);
        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisposeCheck(insa_update, 2);
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisposeCheck(insa_delete, 3);
        }

        private void 검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 조회새로고침ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("조회");
        }

        public void FormDisposeCheck(Form form, int check)
        {
            Console.WriteLine(form.Name);
            if (form.IsDisposed)
            {
                if (check == 1)
                    form = new form_user.insa_record_official.insa_basic.insa_basic_insert();
                else if (check == 2)
                    form = new form_user.insa_record_official.insa_basic.insa_basic_update();
                else if (check == 3)
                    form = new form_user.insa_record_official.insa_basic.insa_basic_delete();

                form.Show();
            }
            else
            {
                form.Show();
            }
        }
    }
}
