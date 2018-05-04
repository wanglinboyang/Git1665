using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
           //播放亭
            ccw();
        }

        private void 获取新放映列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cinema.Schedule1.LoadItems();
            InitTreeView();
        }
        public void InitTreeView() 
        {
            string movieName = string.Empty;
            TreeNode node = null;
            foreach (ScheduleItem item in cinema.Schedule1.Item.Values)
            {
                if (item.Movie1.MovieName1 != movieName)
                { 
                    //一个item代表一个放映场次
                    node = new TreeNode(item.Movie1.MovieName1);
                    tvList.Nodes.Add(node);
                }
                TreeNode tn = new TreeNode(item.Time1);
                node.Nodes.Add(tn);
                movieName = item.Movie1.MovieName1;
            }
        }
       
        Cinema cinema = new Cinema();
        //新放映列表
        string key;
        private void tvList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = tvList.SelectedNode;
            if (node == null) return;
            if (node.Level != 1) return;
            //用于赋值
            key = node.Text;

            //将电影详细信息显示
            try
            {
                this.label2.Text = cinema.Schedule1.Item[key].Movie1.MovieName1;
                this.label9.Text = cinema.Schedule1.Item[key].Movie1.Driector1;
                this.label10.Text = cinema.Schedule1.Item[key].Movie1.Actor1;
                this.label11.Text = cinema.Schedule1.Item[key].Movie1.MovieType1.ToString();
                this.label12.Text = cinema.Schedule1.Item[key].Time1;
                this.label13.Text = cinema.Schedule1.Item[key].Movie1.Price1.ToString();
                this.pictureBox1.Image = Image.FromFile(cinema.Schedule1.Item[key].Movie1.Poster1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = true;
            this.comboBox1.Enabled = false;
            this.comboBox1.Text = "";
            this.label14.Text = "0";
        }
        //学生票
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = false;
            this.textBox1.Text = "";
            this.comboBox1.Enabled = true;
            this.comboBox1.Text = "7";
           // this.comboBox1.Text = "8";
            if (this.label13.Text != "") 
            {
                if (this.comboBox1.Text == "")
                {
                    MessageBox.Show("请选择折扣价格！！");
                    return;
                }
                else
                {
                    int price = int.Parse(this.label13.Text);
                    int discount = int.Parse(this.comboBox1.Text);
                    this.label14.Text = (price * discount / 10).ToString();
                }
            }
        }
        //放映厅
        public void ccw()
        {
            Dictionary<string, Label> labels = new Dictionary<string, Label>();
            int seatRow = 7;//行
            int seatLine = 5;
            for (int i = 0; i < seatRow; i++)
            {
                for (int j = 0; j < seatLine; j++)
                {
                    Label label = new Label();
                    //设置背景颜色
                    label.BackColor = Color.Yellow;
                    //设置字体
                    label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    //设置尺寸
                    label.AutoSize = false;
                    label.Size = new System.Drawing.Size(50, 25);
                    //设置座位号
                    label.Text = (j + 1).ToString() + "_" + (i + 1).ToString();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    //设置位置
                    label.Location = new Point(60 + (i * 90), 60 + (j * 60));
                    //所有的标签都绑定到同一件事
                    label.Click += new System.EventHandler(lblSeat_Click);
                    tabPage2.Controls.Add(label);
                    labels.Add(label.Text, label);
                    //实例化一个座位，Seat构造函数的参数为座位号及颜色
                    Seat seat;
                    seat =new Seat((j+1).ToString()+"-"+(i+1).ToString(),Color.Yellow);
                    //保存的座位集合
                    cinema.Item.Add(seat.SeatNum1, seat);
                }
            }
        }

        private void lblSeat_Click(object sender, EventArgs e)
        {
            //遍历该出场电影的以出售票集合
            foreach (Ticket item in cinema.SoldTickets1)
            {
                //遍历所有位置
                foreach (Seat items in cinema.Item.Values)
                {
                    if ((item.ScheduleItem1.Time1 == key) && (item.Seat1.SeatNum1 == items.SeatNum1))                  
                    {
                        items.Color1 = Color.Red;
                    }
                }
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = false;
            this.comboBox1.Enabled = false;
            this.comboBox1.Text = "";
            this.label14.Text = "";
        }
    }
}
