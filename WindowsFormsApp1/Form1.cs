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
    public partial class Form1 : Form
    {
        public Form1()          //생성자
        {
            InitializeComponent();
            Load += Form1_Load; // 생성자가 만들어 질때 생성괴는것
            
        }

        private void Form1_Load(object sender, EventArgs e) //매서드
        {
            Button btn = new Button();

            btn.DialogResult = DialogResult.OK;
            btn.Text = "확인";
            btn.Size = new Size(100, 50);     // 버튼 사이즈 
            btn.Location = new Point(350, 30);// 버튼 위치점

            Controls.Add(btn);
            btn.Click += btn_click;
        }

        private void btn_click(object o , EventArgs a)
        {
            MessageBox.Show("확인하기");
        }


    }
}
