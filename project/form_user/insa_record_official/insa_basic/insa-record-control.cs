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

        // 조회 데이터베이스
        user.insa_record_official.insa_basic_list insa_list_db = new user.insa_record_official.insa_basic_list();
        // 불러온 유저 리스트 저장 할 변수
        List<String[]> rows_data = new List<String[]>();

        public insacontrol()
        {
            InitializeComponent();
        }

        public void all()
        {
            rows_data = insa_list_db.empno_list();
            int user_count = insa_list_db.empno_list_count();
            DataTable table = new DataTable();

            if (checkedListBox1.Items.Count != 0)
            {
                for (int x = 0; x < checkedListBox1.Items.Count; x++)
                {
                    table.Columns.Add(checkedListBox1.Items[x].ToString(), typeof(string));
                }
            }

            // 개비효율적.
            foreach (String[] k in rows_data)
            {
                    table.Rows.Add(k);
            }
            //table.Rows.Add(k[0], k[1], k[2], k[3], k[4], k[5], k[6], k[7], k[8], k[9], k[10], k[11], k[12], k[13], k[14], k[15], k[16], k[17], k[18], k[19], k[20], k[21], k[22], k[23], k[24], k[25], k[26], k[27],
            //    k[28], k[29], k[30], k[31], k[32], k[33], k[34], k[35], k[36], k[37], k[38], k[39], k[40]);

            dataGridView1.DataSource = table;
        }

        public void list()
        {
            DataTable table = new DataTable();

            if (checkedListBox1.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                    table.Columns.Add(checkedListBox1.CheckedItems[x].ToString(), typeof(string));
            }

            dataGridView1.DataSource = table;
        }

        private void insacontrol_Load(object sender, EventArgs e)
        {
            insa_list_db.connectionOpen();
            checkedListBox1.Enabled = false;
            all();
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Enabled = false;
            all();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Enabled = true;
            list();
        }
    }
}
