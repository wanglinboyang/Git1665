using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jixuanji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "DiamondRed.ssk";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text.Trim()))
            {
                this.textBox1.Focus();
                return;
            }
            try
            {
                string oper = comboBox1.Text;
                Operation op = Calculator.gets(oper);
                op.NumberA = double.Parse(this.textBox1.Text.Trim());
                op.NumberB = double.Parse(this.textBox2.Text.Trim());
                
                this.label2.Text = op.GerResult().ToString();
                this.label2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                label2.Text = "除数不能为0 ! ! ! 你虎逼啊  小学没上过啊？能不能0你不知道啊！！！";
            }
        }
    }
}
