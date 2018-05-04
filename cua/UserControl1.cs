using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cua
{
    public partial class UserControl1 : TextBox
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //if (e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)46 && !(char.IsNumber(e.KeyChar)))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("请输入数字和小数点", "友情提示");
            //    userControl11.Focus();
            //    return;
            //}
            ////<span style="color:#ff0000;">小数点不能在开头</span>  
            //if (e.KeyChar == (char)46 && userControl11.Text.Length == 0)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("请先输入数字", "友情提示");
            //    return;
            //}

            //int a = 0; //计算小数点的个数的变量  
            //a = userControl11.Text.ToString().Trim().Split('.').Length;
            //if (e.KeyChar == (char)46 && a > 1)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("注意只能输入一个小数点", "友情提示");
            //    return;
            //}  

        }
    }
}
