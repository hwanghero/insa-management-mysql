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
    public partial class insainfo : Form
    {
        public insainfo()
        {
            InitializeComponent();
        }

        private void insainfo_Load(object sender, EventArgs e)
        {
            user.form_user_setting form_setting = new user.form_user_setting();
            form_setting.setting(this);
        }
    }
}
