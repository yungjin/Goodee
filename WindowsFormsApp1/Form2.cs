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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e) 
        {
            ListView listView1 = new ListView();

            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();

            columnHeader1.Text = "첫";
            columnHeader2.Text = "둘";
            columnHeader3.Text = "셋";

            columnHeader1.Width = 100;
            columnHeader2.Width = 100;
            columnHeader3.Width = 100;

            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader2.TextAlign = HorizontalAlignment.Left;
            columnHeader3.TextAlign = HorizontalAlignment.Left;

            listView1.Columns.Add(columnHeader1); // 개별로 지정하는것
            listView1.Columns.Add(columnHeader2);
            listView1.Columns.Add(columnHeader3);

            //listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3}); //배열로 범위를 지정하는것 



            //listView1.Columns.Add("Item", 100, HorizontalAlignment.Left); //Add함수를 사용해 한번에 처리하는것
            //listView1.Columns.Add("첫", 150, HorizontalAlignment.Left);
            //listView1.Columns.Add("둘", 200, HorizontalAlignment.Left);
            //listView1.Columns.Add("셋", 300, HorizontalAlignment.Left);


            listView1.GridLines = true;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 426);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;



            Controls.Add(listView1);




            //ListViewItem item1 = new ListViewItem("item1", 0);
            //item1.SubItems.Add("1");                                 
            //item1.SubItems.Add("2");                                 

            //ListViewItem item2 = new ListViewItem("item2", 0);
            //item2.SubItems.Add("ㅇㅅㅇ");
            //item2.SubItems.Add("ㅡㅅㅡ");

            //ListViewItem item3 = new ListViewItem("item3", 0);
            //item3.SubItems.Add("ㅎ");
            //item3.SubItems.Add("ㅛ");

            //listView1.Items.Add(item1);
            //listView1.Items.Add(item2);
            //listView1.Items.Add(item3);

            //listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            ArrayList arry = new ArrayList();
            arry.Add(new Items(new string[] { "item1", "1", "2" }));  //DB에서 가져올때 이방법을 쓴다.
            arry.Add(new Items(new string[] { "item2", "3", "4" }));
            arry.Add(new Items(new string[] { "item3", "5", "6" }));

            ListViewItem item;
            for(int i = 0; i < 3; i++)
            {
                Items row = (Items)arry[i];
                item = new ListViewItem(row.getCol1());
                item.SubItems.Add(row.getCol2());
                item.SubItems.Add(row.getCol3());
                listView1.Items.Add(item);
            }

            string txts = "";
            foreach(ColumnHeader ch in listView1.Columns)
            {
                txts += ch.Text + " ";

            }
            MessageBox.Show(txts);
        }
    }



    public class Items
    {
        string col1;
        string col2;
        string col3;
        public Items(string[] a)
        {
            col1 = a[0];
            col2 = a[1];
            col3 = a[2];
        }

        public string getCol1()
        {
            return col1;
        }
        public string getCol2()
        {
            return col2;
        }
        public string getCol3()
        {
            return col3;
        }
    }
}
