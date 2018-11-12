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

        private Button btn;

        private void Form1_Load(object sender, EventArgs e) //매서드
        {
            for(int i =0; i < 3; i++)
            {
                btn = new Button();

                btn.DialogResult = DialogResult.OK;
                btn.Name = string.Format("btn_{0}", (i + 1));
                btn.Text = string.Format("확인 : {0}", (i + 1));
                btn.Size = new Size(100, 50);     // 버튼 사이즈 
                btn.Location = new Point((100*i) + 30, 30);// 버튼 위치점
                btn.Cursor = Cursors.Hand; //마우스 손모양으로 바꾸기

                Controls.Add(btn); //Controls은 배열이다 배열에 add 해서 btn을 넣은것
                btn.Click += btn_click; //btn.Click에 btn_cclick 을 추가한것

            }
            
        }

        private void btn_click(object o , EventArgs a)//btn.Click 를 매개변수로 받아 오는것,  이벤트에 사용할 값 을 제공
        {
            //string names = "";

            foreach (Control ct in Controls) //ct에 controls 배열을 담은것
            {
                //names += ct.Name + "";
                if(ct.Name != "btn_3")ct.BackColor = Color.Silver;
            }

            //MessageBox.Show(names);

            btn = (Button) o; //명시적 형변환 오브젝트를 버튼 으로 형변환 시킨것
                              
            //if(btn.BackColor == Color.Green)
            //{
            //    btn.BackColor = Color.Silver;
            //}
            //else btn.BackColor = Color.Green; //버튼 누를시 그린으로 색 변환
            btn.BackColor = (btn.BackColor == Color.Green) ? btn.BackColor = Color.Silver : btn.BackColor = Color.Green; //삼합 연산자로 코드 줄인것

            //MessageBox.Show(btn.Text);
        }


    }
}
