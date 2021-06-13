
namespace homework8
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectBox = new System.Windows.Forms.TextBox();
            this.select_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectcomboBox = new System.Windows.Forms.ComboBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.IDBox4 = new System.Windows.Forms.TextBox();
            this.showAll_btn = new System.Windows.Forms.Button();
            this.AddDetail_btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addOrder_btn = new System.Windows.Forms.Button();
            this.modifyOrder_btn = new System.Windows.Forms.Button();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(387, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // selectBox
            // 
            this.selectBox.Location = new System.Drawing.Point(88, 19);
            this.selectBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(69, 21);
            this.selectBox.TabIndex = 0;
            this.selectBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(178, 12);
            this.select_btn.Margin = new System.Windows.Forms.Padding(2);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(94, 38);
            this.select_btn.TabIndex = 4;
            this.select_btn.Text = "查询";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.selectcomboBox);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.IDBox4);
            this.panel1.Controls.Add(this.showAll_btn);
            this.panel1.Controls.Add(this.select_btn);
            this.panel1.Controls.Add(this.selectBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 60);
            this.panel1.TabIndex = 1;
            // 
            // selectcomboBox
            // 
            this.selectcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectcomboBox.FormattingEnabled = true;
            this.selectcomboBox.Items.AddRange(new object[] {
            "ID",
            "客户名",
            "金额数"});
            this.selectcomboBox.Location = new System.Drawing.Point(9, 19);
            this.selectcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectcomboBox.Name = "selectcomboBox";
            this.selectcomboBox.Size = new System.Drawing.Size(53, 20);
            this.selectcomboBox.TabIndex = 28;
            this.selectcomboBox.SelectedIndexChanged += new System.EventHandler(this.selectcomboBox_SelectedIndexChanged);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(600, 18);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(86, 36);
            this.delete_btn.TabIndex = 27;
            this.delete_btn.Text = "删除订单";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 15F);
            this.label11.Location = new System.Drawing.Point(422, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "订单号";
            // 
            // IDBox4
            // 
            this.IDBox4.Location = new System.Drawing.Point(504, 23);
            this.IDBox4.Margin = new System.Windows.Forms.Padding(2);
            this.IDBox4.Name = "IDBox4";
            this.IDBox4.Size = new System.Drawing.Size(75, 21);
            this.IDBox4.TabIndex = 3;
            this.IDBox4.TextChanged += new System.EventHandler(this.IDBox4_TextChanged);
            // 
            // showAll_btn
            // 
            this.showAll_btn.Location = new System.Drawing.Point(294, 11);
            this.showAll_btn.Margin = new System.Windows.Forms.Padding(2);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(91, 39);
            this.showAll_btn.TabIndex = 5;
            this.showAll_btn.Text = "展示所有";
            this.showAll_btn.UseVisualStyleBackColor = true;
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // AddDetail_btn
            // 
            this.AddDetail_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddDetail_btn.Location = new System.Drawing.Point(102, 2);
            this.AddDetail_btn.Margin = new System.Windows.Forms.Padding(2);
            this.AddDetail_btn.Name = "AddDetail_btn";
            this.AddDetail_btn.Size = new System.Drawing.Size(97, 42);
            this.AddDetail_btn.TabIndex = 23;
            this.AddDetail_btn.Text = "添加明细";
            this.AddDetail_btn.UseVisualStyleBackColor = true;
            this.AddDetail_btn.Click += new System.EventHandler(this.AddDetail_btn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressDataGridViewTextBoxColumn,
            this.commodityDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderDetailBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(403, 69);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(364, 243);
            this.dataGridView2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.modifyOrder_btn);
            this.flowLayoutPanel1.Controls.Add(this.AddDetail_btn);
            this.flowLayoutPanel1.Controls.Add(this.addOrder_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 325);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(778, 55);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // addOrder_btn
            // 
            this.addOrder_btn.Location = new System.Drawing.Point(203, 2);
            this.addOrder_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addOrder_btn.Name = "addOrder_btn";
            this.addOrder_btn.Size = new System.Drawing.Size(107, 42);
            this.addOrder_btn.TabIndex = 0;
            this.addOrder_btn.Text = "增加订单";
            this.addOrder_btn.UseVisualStyleBackColor = true;
            this.addOrder_btn.Click += new System.EventHandler(this.addOrder_btn_Click_1);
            // 
            // modifyOrder_btn
            // 
            this.modifyOrder_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyOrder_btn.Location = new System.Drawing.Point(2, 2);
            this.modifyOrder_btn.Margin = new System.Windows.Forms.Padding(2);
            this.modifyOrder_btn.Name = "modifyOrder_btn";
            this.modifyOrder_btn.Size = new System.Drawing.Size(96, 42);
            this.modifyOrder_btn.TabIndex = 1;
            this.modifyOrder_btn.Text = "修改订单项";
            this.modifyOrder_btn.UseVisualStyleBackColor = true;
            this.modifyOrder_btn.Click += new System.EventHandler(this.modifyOrder_btn_Click_1);
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // commodityDataGridViewTextBoxColumn
            // 
            this.commodityDataGridViewTextBoxColumn.DataPropertyName = "Commodity";
            this.commodityDataGridViewTextBoxColumn.HeaderText = "Commodity";
            this.commodityDataGridViewTextBoxColumn.Name = "commodityDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(homework8.OrderDetail);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 80;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.moneyDataGridViewTextBoxColumn.Width = 80;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(homework8.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(778, 380);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "订单管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.TextBox selectBox;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Button showAll_btn;
        private System.Windows.Forms.Button AddDetail_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IDBox4;
        private System.Windows.Forms.ComboBox selectcomboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addOrder_btn;
        private System.Windows.Forms.Button modifyOrder_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}

