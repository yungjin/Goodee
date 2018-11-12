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
    public partial class Form1 : Form
    {
        public Form1()          //생성자
        {

            InitializeComponent();
            Load += Form1_Load; // 생성자가 만들어 질때 생성괴는것

        }

        private Button btn;
        private Label lb;

        private void Form1_Load(object sender, EventArgs e) //매서드
        {
            //가상 데이터 생성
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Item("button",30, 30,"btn_1"));
            arrayList.Add(new Item("label", 30, 110, "lb_1"));
            arrayList.Add(new Item("button", 30, 190, "btn_2"));

            //가상 데이터를 이용한 화면 구성
            for (int i = 0; i < arrayList.Count; i++)
            {
                Control_create((Item)arrayList[i]);
            }

            //1차원 배열로 화면구성
            //string[] ctrList = { "button", "label", "button" };
            //for(int i =0; i < 3; i++)
            //{
            //    if (ctrList[i] == "button") Controls.Add(btn_create(i)); 
            //    else if (ctrList[i] == "label")Controls.Add(lb_creaet(i)); //리던 값(btn)을 받아오는것

            //}

        }

        private void Control_create(Item item)
        {
            Control ctr = new Control();

            switch (item.getType())
            {
                case "button":
                    Button btn = new Button();
                    btn.DialogResult = DialogResult.OK;
                    btn.Cursor = Cursors.Hand;
                    btn.Click += btn_click;
                    ctr = btn;
                    break;
                case "label":
                    ctr = new Label();
                    break;
                default:
                    break;
                    
            }

            ctr.Name = item.getTxt();
            ctr.Text = item.getTxt();
            ctr.Size = new Size(100, 50);
            ctr.Location = new Point(item.getX(), item.getY());
            Controls.Add(ctr);
            
        }


        private Button btn_create(int i) //컨트롤 부분
        {
            btn = new Button();

            btn.DialogResult = DialogResult.OK;
            btn.Name = string.Format("btn_{0}", (i + 1));
            btn.Text = string.Format("확인 : {0}", (i + 1));
            btn.Size = new Size(100, 50);     // 버튼 사이즈 
            btn.Location = new Point((100 * i) + 30, 30);// 버튼 위치점
            btn.Cursor = Cursors.Hand; //마우스 손모양으로 바꾸기
            btn.Click += btn_click; //btn.Click에 btn_cclick 을 추가한것

            return btn;//btn을 리턴해줘서 
        }



        private Label lb_creaet(int i)
        {
            lb = new Label();

            lb.Name = string.Format("lb_{0}", (i + 1));
            lb.Text = string.Format("확인 : {0}", (i + 1));
            lb.Size = new Size(100, 50);     // 버튼 사이즈 
            lb.Location = new Point((100 * i) + 30, 30);// 버튼 위치점
            lb.Cursor = Cursors.Hand; //마우스 손모양으로 바꾸기
            lb.Click += btn_click; //btn.Click에 btn_cclick 을 추가한것

            return lb;
        }

        private void btn_click(object o, EventArgs a)//btn.Click 를 매개변수로 받아 오는것,  이벤트에 사용할 값 을 제공
        {
            //string names = "";

            foreach (Control ct in Controls) //ct에 controls 배열을 담은것
            {
                //names += ct.Name + "";
                if (ct.Name != "btn_3") ct.BackColor = Color.Silver;
            }

            //MessageBox.Show(names);

            btn = (Button)o;//명시적 형변환 오브젝트를 버튼 으로 형변환 시킨것, btn 이 자기 자신인것을 알리기 위해 선언한것

            //if (btn.BackColor == Color.Green)
            //{
            //    btn.BackColor = Color.Silver;
            //}
            //else btn.BackColor = Color.Green; //버튼 누를시 그린으로 색 변환
            btn.BackColor = (btn.BackColor == Color.Green) ? btn.BackColor = Color.Silver : btn.BackColor = Color.Green; //삼합 연산자로 코드 줄인것

            //MessageBox.Show(btn.Text);
        }


    }

    public class Item //맴버 객체 
    {
        private string type;
        private int x;
        private int y;
        private string txt;

        public Item(string type, int x, int y, string txt) //생성자
        {
            this.type = type;
            this.x = x;
            this.y = y;
            this.txt = txt;
        }
        public string getType()
        {
            return type;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public string getTxt()
        {
            return txt;
        }
    }
}
