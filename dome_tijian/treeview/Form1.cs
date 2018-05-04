using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nodename = textBox1.Text;
            TreeNode tn = new TreeNode();
            tn.Text = nodename;
            treeView1.Nodes.Add(tn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nodename = textBox1.Text;
            TreeNode tn = new TreeNode();
            tn.Text = nodename;
            TreeNode selectedNode = treeView1.SelectedNode;
            foreach (TreeNode item in selectedNode.Nodes)
            {
                if (item.Text == nodename) 
                {
                    MessageBox.Show("该子类已存在");
                    return;
                }
            }
            selectedNode.Nodes.Add(tn);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode select = treeView1.SelectedNode;
            MessageBox.Show(select.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
