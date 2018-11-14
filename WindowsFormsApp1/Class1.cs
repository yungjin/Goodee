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
        

        public void btn(Form form, string name , string text , int sx ,int sy ,int px,int py)
        {
            Button btn = new Button();

            btn.DialogResult = DialogResult.OK;
            btn.Name = name;
            btn.Text = text;
            btn.Size = new Size(sx, sy);
            btn.Location = new Point(px, py);
            btn.Cursor = Cursors.Hand; 

            form.Controls.Add(btn);
        }

    }
}
