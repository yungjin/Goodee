using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            Load += Form4_Load;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Class1 c1 = new Class1(this);
            c1.btn();

        }
    }
}
