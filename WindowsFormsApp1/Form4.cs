using System;
using System.Collections;
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
            Class1 c1 = new Class1();
            ArrayList arr = new ArrayList();
            arr.Add(new Class2(this, "btn 1", " 버튼 1", 100, 50, 30, 30));
            arr.Add(new Class2(this, "btn 2", " 버튼 2", 100, 50, 30, 90));

            for(int i = 0; i < arr.Count; i++)
            {
                c1.btn((Class2)arr[i]);
            }
            
        }
    }
}
