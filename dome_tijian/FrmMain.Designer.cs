namespace dome_tijian
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTao = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.gbBoxx = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdds = new System.Windows.Forms.Button();
            this.cmbXiang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLie = new System.Windows.Forms.ComboBox();
            this.lblTao = new System.Windows.Forms.Label();
            this.gpBox.SuspendLayout();
            this.gbBoxx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBox
            // 
            this.gpBox.Controls.Add(this.btnAdd);
            this.gpBox.Controls.Add(this.txtTao);
            this.gpBox.Controls.Add(this.lblN);
            this.gpBox.Location = new System.Drawing.Point(13, 34);
            this.gpBox.Name = "gpBox";
            this.gpBox.Size = new System.Drawing.Size(670, 115);
            this.gpBox.TabIndex = 0;
            this.gpBox.TabStop = false;
            this.gpBox.Text = "新建套餐";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(476, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTao
            // 
            this.txtTao.Location = new System.Drawing.Point(198, 48);
            this.txtTao.Name = "txtTao";
            this.txtTao.Size = new System.Drawing.Size(206, 25);
            this.txtTao.TabIndex = 1;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(88, 51);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(67, 15);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "套餐姓名";
            // 
            // gbBoxx
            // 
            this.gbBoxx.Controls.Add(this.dataGridView1);
            this.gbBoxx.Controls.Add(this.label5);
            this.gbBoxx.Controls.Add(this.label4);
            this.gbBoxx.Controls.Add(this.label3);
            this.gbBoxx.Controls.Add(this.label2);
            this.gbBoxx.Controls.Add(this.btnDelete);
            this.gbBoxx.Controls.Add(this.btnAdds);
            this.gbBoxx.Controls.Add(this.cmbXiang);
            this.gbBoxx.Controls.Add(this.label1);
            this.gbBoxx.Controls.Add(this.cmbLie);
            this.gbBoxx.Controls.Add(this.lblTao);
            this.gbBoxx.Location = new System.Drawing.Point(13, 179);
            this.gbBoxx.Name = "gbBoxx";
            this.gbBoxx.Size = new System.Drawing.Size(674, 418);
            this.gbBoxx.TabIndex = 1;
            this.gbBoxx.TabStop = false;
            this.gbBoxx.Text = "检查套餐维护";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(18, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(635, 214);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // c
            // 
            this.c.DataPropertyName = "HealthItemName";
            this.c.HeaderText = "项目名";
            this.c.Name = "c";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "healthItemDesc";
            this.Column2.HeaderText = "描述";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "heathItemPrice";
            this.Column3.HeaderText = "价格";
            this.Column3.Name = "Column3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "价格：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "套餐名：";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(476, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdds
            // 
            this.btnAdds.Location = new System.Drawing.Point(355, 121);
            this.btnAdds.Name = "btnAdds";
            this.btnAdds.Size = new System.Drawing.Size(76, 35);
            this.btnAdds.TabIndex = 4;
            this.btnAdds.Text = "添加";
            this.btnAdds.UseVisualStyleBackColor = true;
            this.btnAdds.Click += new System.EventHandler(this.btnAdds_Click);
            // 
            // cmbXiang
            // 
            this.cmbXiang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXiang.FormattingEnabled = true;
            this.cmbXiang.Items.AddRange(new object[] {
            "请选择"});
            this.cmbXiang.Location = new System.Drawing.Point(464, 59);
            this.cmbXiang.Name = "cmbXiang";
            this.cmbXiang.Size = new System.Drawing.Size(136, 23);
            this.cmbXiang.TabIndex = 3;
            this.cmbXiang.SelectedIndexChanged += new System.EventHandler(this.cmbXiang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "检查项目";
            // 
            // cmbLie
            // 
            this.cmbLie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLie.FormattingEnabled = true;
            this.cmbLie.Items.AddRange(new object[] {
            "请选择"});
            this.cmbLie.Location = new System.Drawing.Point(198, 59);
            this.cmbLie.Name = "cmbLie";
            this.cmbLie.Size = new System.Drawing.Size(139, 23);
            this.cmbLie.TabIndex = 1;
            this.cmbLie.SelectedIndexChanged += new System.EventHandler(this.cmbLie_SelectedIndexChanged);
            // 
            // lblTao
            // 
            this.lblTao.AutoSize = true;
            this.lblTao.Location = new System.Drawing.Point(88, 59);
            this.lblTao.Name = "lblTao";
            this.lblTao.Size = new System.Drawing.Size(67, 15);
            this.lblTao.TabIndex = 0;
            this.lblTao.Text = "套餐列表";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 609);
            this.Controls.Add(this.gbBoxx);
            this.Controls.Add(this.gpBox);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "体检套餐管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            this.gbBoxx.ResumeLayout(false);
            this.gbBoxx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTao;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.GroupBox gbBoxx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdds;
        private System.Windows.Forms.ComboBox cmbXiang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLie;
        private System.Windows.Forms.Label lblTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

