using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.user
{
    class form_user_setting
    {
        Size penal = new Size();
        public void setSize(Size a)
        {
            penal = a;
        }

        public Size getSize()
        {
            return penal;
        }

        // 자식 폼 설정.
        public void setting(Form form)
        {
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = penal;
        }
    }
}
