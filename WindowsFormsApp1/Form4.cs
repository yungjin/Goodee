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
            arr.Add(new Class2(this, "btn_1", " 버튼 1", 100, 50, 30, 30, btn1_Click));
            arr.Add(new Class2(this,"btn_2", " 버튼 2", 100, 50, 30, 90, btn2_Click));
            arr.Add(new Class3(this,"lb_1", " 라벨 1", 100, 50, 160, 30));

            for (int i = 0; i < arr.Count; i++)
            {
                if (typeof( Class2 )== arr[i].GetType()) //타입 비교시 typeof 사용 해당 객체가 어떤 데이터 타입인지 알려준다. 
                                                         //GetType 은 해당 인스턴스 의 타입을 가져온다.
                {
                    c1.btn((Class2)arr[i]);
                }
                else if (typeof(Class3) == arr[i].GetType())
                {
                    c1.lb((Class3)arr[i]);
                }
            }
        }

        private void btn1_Click(Object o , EventArgs e)
        {
            MessageBox.Show("버튼1 오픈");
        }
        private void btn2_Click(Object o, EventArgs e)
        {
            MessageBox.Show("버튼2 오픈");
        }
    }
}
