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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Load += Form3_Load;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //가상 데이터 생성 > DB 연결시 DB에서 가져오면 됨
            ArrayList col_list = new ArrayList();
            ArrayList item_list = new ArrayList();

            //헤더 쪽 데이터 생성
            col_list.Add(new string[] { "첫","100","L"});
            col_list.Add(new string[] { "둘","150","R"});
            col_list.Add(new string[] { "셋","200","C"});

            //아이템 쪽 데이터 생성
            item_list.Add(new Items(new string[] { "item1", "1", "2" }));  //DB에서 가져올때 이방법을 쓴다.
            item_list.Add(new Items(new string[] { "item2", "3", "4" }));
            item_list.Add(new Items(new string[] { "item3", "5", "6" }));

            ListView lv = lv_create(col_list, item_list);
            Controls.Add(lv);
        }

        private ListView lv_create(ArrayList col_list,ArrayList item_list)
        {
            ListView lv = new ListView();
            
            //리스트뷰 속성 설정
            lv.GridLines = true;
            lv.Location = new Point(12, 12);
            lv.Name = "listView1";
            lv.Size = new Size(776, 426);
            lv.TabIndex = 0;
            lv.UseCompatibleStateImageBehavior = false;
            lv.View = View.Details;

            //헤더 설정
            //for(int i = 0; i < col_list.Count; i++)
            //{
            //    string[] arr = (string[]) col_list[i];
            //    ColumnHeader columnHeader = new ColumnHeader();
            //    columnHeader.Text = arr[0];
            //    columnHeader.Width = Convert.ToInt32(arr[1]);
            //    switch(arr[2])
            //    {
            //        case "L":
            //            columnHeader.TextAlign = HorizontalAlignment.Left;
            //            break;
            //        case "R":
            //            columnHeader.TextAlign = HorizontalAlignment.Right;
            //            break;
            //        case "C":
            //            columnHeader.TextAlign = HorizontalAlignment.Center;
            //            break;
            //    }

            //    lv.Columns.Add(columnHeader);
            //}
            bool h_check = ch_create(col_list, lv); //헤더 부분을 밖으로 빼는방법

            //아이템 설정
            for (int i = 0; i < item_list.Count; i++)
            {
                Items row = (Items)item_list[i];
                ListViewItem item = new ListViewItem(row.getCol1());
                item.SubItems.Add(row.getCol2());
                item.SubItems.Add(row.getCol3());
                lv.Items.Add(item);
            }

            return lv;
        }
        
        private bool ch_create(ArrayList col_list, ListView lv) //헤더 부분을 밖으로 빼는방법 불린값을 받는 방법
        {
            for (int i = 0; i < col_list.Count; i++)
            {
                string[] arr = (string[])col_list[i];
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = arr[0];
                columnHeader.Width = Convert.ToInt32(arr[1]);
                switch (arr[2])
                {
                    case "L":
                        columnHeader.TextAlign = HorizontalAlignment.Left;
                        break;
                    case "R":
                        columnHeader.TextAlign = HorizontalAlignment.Right;
                        break;
                    case "C":
                        columnHeader.TextAlign = HorizontalAlignment.Center;
                        break;
                }
                lv.Columns.Add(columnHeader);
            }
            return true;
        }
    }
}
