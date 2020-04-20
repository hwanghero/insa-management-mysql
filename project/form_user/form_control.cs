using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.form_user
{
    public partial class form_control : Form
    {
        insacontrol insa_control;

        public form_control()
        {
            InitializeComponent();
        }

        public form_control(insacontrol insa_control)
        {
            InitializeComponent();
            this.insa_control = insa_control;
        }

        static String mode;

        public static void set_mode(String setmode)
        {
            mode = setmode;
        }
        public static string get_mode()
        {
            return mode;
        }

        private void insert_b_Click(object sender, EventArgs e)
        {
            Console.WriteLine(mode);
            if (mode.Equals("인사기본사항"))
            {
                //applyEnabled(true);
                //buttonEnabled(false);
                //textbox_enable(true);
                Console.WriteLine("insert");
                insa_control.textbox_enable(true);
            }

            applyEnabled(true);
            buttonEnabled(false);
        }

        private void update_b_Click(object sender, EventArgs e)
        {
            if (mode.Equals("인사기본사항"))
            {
                Console.WriteLine("update");
                insa_control.textbox_enable(true);
                
            }
            applyEnabled(true);
            buttonEnabled(false);
        }

        private void delete_b_Click(object sender, EventArgs e)
        {
            if (mode.Equals("인사기본사항"))
            {
                Console.WriteLine("delete");
                insa_control.textbox_enable(false);
            }
            applyEnabled(true);
            buttonEnabled(false);
        }

        private void apply_b_Click(object sender, EventArgs e)
        {
            if (mode.Equals("인사기본사항"))
            {
                Console.WriteLine("apply");
                insa_control.textbox_enable(false);
            }
            applyEnabled(false);
            buttonEnabled(true);
        }

        private void cancel_b_Click(object sender, EventArgs e)
        {
            if (mode.Equals("인사기본사항"))
            {
                Console.WriteLine("cancel");
                insa_control.textbox_enable(false);
            }
            applyEnabled(false);
            buttonEnabled(true);
        }

        private void form_control_Load(object sender, EventArgs e)
        {

        }
        public void applyEnabled(Boolean check)
        {
            apply_b.Enabled = check;
            cancel_b.Enabled = check;
        }
        public void buttonEnabled(Boolean check)
        {
            insert_b.Enabled = check;
            update_b.Enabled = check;
            delete_b.Enabled = check;
        }
    }
}
