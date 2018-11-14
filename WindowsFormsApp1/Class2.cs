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
            this.text = text;
            this.sx = sx;
            this.sy = sy;
            this.px = px;
            this.py = py;
        }

        public Form Form
        {
            get
            {
                return Form;
            }

        }
        public string Name
        {
            get
            {
                return Name;
            }

        }

        public string Text
        {
            get
            {
                return Text;
            }

        }
        public int Sx
        {
            get
            {
                return Sx;
            }

        }
        public int Sy
        {
            get
            {
                return Sy;
            }

        }
        public int Px
        {
            get
            {
                return Px;
            }

        }
        public int Py
        {
            get
            {
                return Py;
            }

        }
    }
}
