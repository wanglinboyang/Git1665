using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dome_tijian
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }                  //身高    体重   视力  听力     肝功能  心电图  B超    血压            血常规
        public HealthItem height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;
        Dictionary<string,HealthItem> AllItems = new Dictionary<string,HealthItem>();
        public Dictionary<string, HealthSet> hsets = new Dictionary<string, HealthSet>();
        HealthSet setA;
        private void FrmMain_Load(object sender, EventArgs e)
        {

           


            //A套餐的体检项目集合
            Dictionary<string, HealthItem> heal = new Dictionary<string, HealthItem>();
            //初始化3个体检项目
            height = new HealthItem("身高","用于体检身高",30);
            weight = new HealthItem("体重","用于检查体重",40);
            hearing = new HealthItem("听力","用于检测听力",30);
            heal.Add(height.HealthItemName, height);
            heal.Add(weight.HealthItemName,weight);
            heal.Add(hearing.HealthItemName,hearing);
            //01.构建出一个套餐对象  代表的是入学体检
            setA = new HealthSet("入学体检",heal);
            //02.套餐对象归属于一个套餐集合
            hsets.Add(setA.HeahthName, setA);  
            //计算价格
            setA.CalcPrice();
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = hsets.Keys;
            cmbLie.DataSource = bs2;
            
            
           




            height = new HealthItem("身高", "用于检查身高.", 10);
            weight = new HealthItem("体重", "用于检查体重.", 20);
            sight = new HealthItem("视力", "用于检查视力.", 5);
            hearing = new HealthItem("听力", "用于检查听力.", 5);
            liverFun = new HealthItem("肝功能", "用于检查肝功能.", 5);
            bWaves = new HealthItem("B超", "用于检查B超.", 30);
            ekg = new HealthItem("心电图", "用于检查心电图.", 30);
            bloodPressure = new HealthItem("血压", "用于检查血压.", 10);
            bloodTest = new HealthItem("血常规", "用于检查血常规.", 20);
            AllItems.Add(height.HealthItemName, height);
            AllItems.Add(weight.HealthItemName, weight);
            AllItems.Add(sight.HealthItemName, sight);
            AllItems.Add(hearing.HealthItemName, hearing);
            AllItems.Add(liverFun.HealthItemName, liverFun);
            AllItems.Add(bWaves.HealthItemName, bWaves);
            AllItems.Add(ekg.HealthItemName, ekg);
            AllItems.Add(bloodPressure.HealthItemName, bloodPressure);
            AllItems.Add(bloodTest.HealthItemName, bloodTest);

            label3.Text = cmbLie.Text;
             cmbXiang.SelectedIndex = 0;
             foreach (string item in AllItems.Keys)
             {
                 cmbXiang.Items.Add(item);
             }
        }

        private void cmbLie_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                BindingSource bs = new BindingSource();
                bs.DataSource = hsets[cmbLie.Text].HealthItems.Values;
                dataGridView1.DataSource = bs;
                string setName = this.cmbLie.Text;
                if (setName == "请选择") 
                {
                    this.dataGridView1.DataSource = new BindingList<HealthItem>();
                    label3.Text = "";
                    label5.Text = "";
                    return;
                }
            //设置套餐
                label3.Text = hsets[setName].HeahthName;
            //设置套餐总价格
                label5.Text = this.hsets[setName].HealthPrice.ToString();
            //更新套餐检查项目
                Update(hsets[setName]);
            //设置删除按键为“可用状态”
                this.btnAdds.Enabled = true;
        }
        public void Update( HealthSet set) 
        {
           // dgvHealthList.DataSource = new BindingList<HealthCheckItem>(set.Items.Values.ToList());
            dataGridView1.DataSource = new BindingList<HealthItem>(set.HealthItems.Values.ToList());
        }
        public void InitItems()
        {
            //创建Item对象并保存到集合中 --注意如果使用List<T> 必须与下拉列表中的索引一致
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
        //    if (string.IsNullOrEmpty(this.txtHealthName.Text.Trim()))
        //    {
        //        MessageBox.Show("请输入套餐名称!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    HealthCheckSet Hch = new HealthCheckSet();
        //    this.HealthSet.Add(this.txtHealthName.Text.Trim(), Hch);

        //    this.InitHealthSetList();
        //    this.cboSets.SelectedIndex = this.HealthSet.Count;
        //    MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //} 
            if (string.IsNullOrEmpty(this.txtTao.Text.Trim())) 
            {
                MessageBox.Show("请输入套餐名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HealthSet hch = new HealthSet();
            this.hsets.Add(this.txtTao.Text.Trim(), hch);

            this.InitHealthSetList();
            this.cmbLie.SelectedIndex = this.hsets.Count;
            MessageBox.Show("添加成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void InitHealthSetList()
        {
            //this.cmbLie.Items.Clear();
            //this.cmbLie.Items.Add("请选择");
            //foreach (string  item in this.hsets.Keys)
            //{
            //    this.cmbLie.Items.Add(item);
            //}
            this.cmbLie.SelectedIndex = 0;
            //this.cboSets.Items.Clear();
            //this.cboSets.Items.Add("请选择");

            //foreach (string key in this.HealthSet.Keys)
            //{
            //    this.cboSets.Items.Add(key);
            //}
            //this.cboSets.SelectedIndex = 0;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdds_Click(object sender, EventArgs e)//添加
        {
            //添加 检查项
            if (this.cmbXiang.SelectedIndex == 0)
            {
                MessageBox.Show("请选择一个项目");
                return;
            }
            string cmb = this.cmbLie.Text;
            if (cmb == "请选择")
            {
                MessageBox.Show("请选择一个套餐！");
                return;
            } 
            //添加操作
            int index = this.cmbXiang.SelectedIndex - 1;
            string wangtAdd = this.cmbXiang.Text;

            if (!hsets[cmb].HealthItems.Keys.ToList().Contains(wangtAdd))
            {
                //添加检查项
                this.hsets[cmb].HealthItems.Add(wangtAdd, AllItems[wangtAdd]);
                //重新计算总价格
                this.hsets[cmb].CalcPrice();
                //更新
                Update(this.hsets[cmb]);
                this.label3.Text = this.hsets[cmb].HeahthName;//刷新窗体集合A名称
                this.label5.Text = this.hsets[cmb].HealthPrice.ToString();//出新集合A价格
                MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("项目已存在！");
            }
        }
       // HealthSet setA;
        //删除项目
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string setName = this.cmbLie.Text;
            if (this.dataGridView1.SelectedRows.Count == 0) 
            {
                MessageBox.Show("没有选择删除项目。","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
             //获取选中检查项目的索引
            int index = this.dataGridView1.SelectedRows[0].Index;
            string key = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
             //删除检查项
            this.hsets[setName].HealthItems.Remove(key);

            //重新计算价格
            this.hsets[setName].CalcPrice();
            //更新dataGridView显示
            Update(hsets[setName]);

            //重设标签显示
            this.label3.Text = setA.HeahthName;
            this.label5.Text = setA.HealthPrice.ToString();
            MessageBox.Show("删除成功1","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmbXiang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbXiang.Text != "请选择")
            {
                this.btnAdds.Enabled = true;
            }
            else 
            {
                this.btnAdds.Enabled = false;
            }
        }
        
    
    }
}
