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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Load += Form5_Load;
        }
        Panel panel1;

        private void Form5_Load(object sender, EventArgs e)
        {
            //Form5 에 Form6 띄우기
            this.IsMdiContainer = true;
            Size = new Size(1000, 800);

            panel1 = new Panel();
            panel1.Location = new Point(0, 80);
            panel1.Size = new Size(1000, 400);
            Controls.Add(panel1);

            Class1 c1 = new Class1();
            c1.btn(new Class2(this, "btn_1", " 버튼 1", 100, 50, 0, 0, btn_Click));
        }

        private void btn_Click(Object o,EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.MdiParent = this;
            panel1.Controls.Add(f6);
            f6.Show();


        }
    }
}
