using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    
    class Class2
    {
        Form form;
        string name;
        string text;
        int sx;
        int sy;
        int px;
        int py;

        public Class2(Form form, string name, string text, int sx, int sy, int px, int py)
        {
            this.form = form;
            this.name = name;
            this.sx = sx;
            this.sy = sy;
            this.px = px;
            this.py = py;
        }

        Form Form
        {
            get
            {
                return Form;
            }

        }
        string Name
        {
            get
            {
                return Name;
            }

        }

        string Text
        {
            get
            {
                return Text;
            }

        }
        int Sx
        {
            get
            {
                return Sx;
            }

        }
        int Sy
        {
            get
            {
                return Sy;
            }

        }
        int Px
        {
            get
            {
                return Px;
            }

        }
        int Py
        {
            get
            {
                return Py;
            }

        }
    }
}
