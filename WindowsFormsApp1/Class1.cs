using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Class1
    {
        Form form;
        public Class1(Form form)
        {
            this.form = form;


        }

        public void btn()
        {
            Button btn = new Button();

            btn.DialogResult = DialogResult.OK;
            btn.Name = string.Format("btn_{0}", (1));
            btn.Text = string.Format("확인 : {0}", (1));
            btn.Size = new Size(100, 50);     // 버튼 사이즈 
            btn.Location = new Point(30, 30);// 버튼 위치점
            btn.Cursor = Cursors.Hand; //마우스 손모양으로 바꾸기

            form.Controls.Add(btn);
            
        }

    }
}
