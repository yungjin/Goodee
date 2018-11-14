using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Class1
    {
        
        public void btn(Class2 c2)
        {
            Button btn = new Button();

            btn.DialogResult = DialogResult.OK;
            btn.Name = c2.Name;
            btn.Text = c2.Text;
            btn.Size = new Size(c2.Sx, c2.Sy);
            btn.Location = new Point(c2.Px, c2.Py);
            btn.Cursor = Cursors.Hand;
            btn.Click += c2.eh;
            c2.Form.Controls.Add(btn);
        }
        public void lb(Class3 c3)
        {
            Label label = new Label();

            label.Name = c3.Name;
            label.Text = c3.Text;
            label.Size = new Size(c3.Sx, c3.Sy);
            label.Location = new Point(c3.Px, c3.Py);
            label.Cursor = Cursors.Hand;

            c3.Form.Controls.Add(label);
        }


    }
}
