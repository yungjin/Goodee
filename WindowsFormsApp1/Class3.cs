using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Class3
    {
        Form form;
        string name;
        string text;
        int sx;
        int sy;
        int px;
        int py;

        public Class3(Form form, string name, string text, int sx, int sy, int px, int py)
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
                return form;
            }

        }
        
        public string Name
        {
            get
            {
                return name;
            }

        }

        public string Text
        {
            get
            {
                return text;
            }

        }
        public int Sx
        {
            get
            {
                return sx;
            }

        }
        public int Sy
        {
            get
            {
                return sy;
            }

        }
        public int Px
        {
            get
            {
                return px;
            }

        }
        public int Py
        {
            get
            {
                return py;
            }

        }
    }
}

