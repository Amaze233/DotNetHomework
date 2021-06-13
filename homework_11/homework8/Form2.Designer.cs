
namespace homework8
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Addorder_btn = new System.Windows.Forms.Button();
            this.customerBox2 = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.IDBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.IDBox3 = new System.Windows.Forms.TextBox();
            this.AddDetail_btn = new System.Windows.Forms.Button();
            this.goodsBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Addorder_btn);
            this.panel1.Controls.Add(this.customerBox2);
            this.panel1.Controls.Add(this.dateBox);
            this.panel1.Controls.Add(this.IDBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 117);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13F);
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "客户名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13F);
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13F);
            this.label6.Location = new System.Drawing.Point(9, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID";
            // 
            // Addorder_btn
            // 
            this.Addorder_btn.Location = new System.Drawing.Point(160, 38);
            this.Addorder_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addorder_btn.Name = "Addorder_btn";
            this.Addorder_btn.Size = new System.Drawing.Size(94, 50);
            this.Addorder_btn.TabIndex = 29;
            this.Addorder_btn.Text = "添加/修改完成";
            this.Addorder_btn.UseVisualStyleBackColor = true;
            this.Addorder_btn.Click += new System.EventHandler(this.Addorder_btn_Click);
            // 
            // customerBox2
            // 
            this.customerBox2.Location = new System.Drawing.Point(69, 85);
            this.customerBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerBox2.Name = "customerBox2";
            this.customerBox2.Size = new System.Drawing.Size(68, 21);
            this.customerBox2.TabIndex = 28;
            this.customerBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(69, 49);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(68, 21);
            this.dateBox.TabIndex = 27;
            this.dateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IDBox2
            // 
            this.IDBox2.Location = new System.Drawing.Point(69, 13);
            this.IDBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDBox2.Name = "IDBox2";
            this.IDBox2.Size = new System.Drawing.Size(69, 21);
            this.IDBox2.TabIndex = 26;
            this.IDBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.IDBox3);
            this.panel2.Controls.Add(this.AddDetail_btn);
            this.panel2.Controls.Add(this.goodsBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.priceBox);
            this.panel2.Controls.Add(this.numberBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 138);
            this.panel2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 13F);
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 34;
            this.label10.Text = "订单号";
            // 
            // IDBox3
            // 
            this.IDBox3.Location = new System.Drawing.Point(68, 13);
            this.IDBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDBox3.Name = "IDBox3";
            this.IDBox3.Size = new System.Drawing.Size(69, 21);
            this.IDBox3.TabIndex = 33;
            this.IDBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddDetail_btn
            // 
            this.AddDetail_btn.Location = new System.Drawing.Point(160, 45);
            this.AddDetail_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddDetail_btn.Name = "AddDetail_btn";
            this.AddDetail_btn.Size = new System.Drawing.Size(94, 53);
            this.AddDetail_btn.TabIndex = 32;
            this.AddDetail_btn.Text = "添加明细";
            this.AddDetail_btn.UseVisualStyleBackColor = true;
            this.AddDetail_btn.Click += new System.EventHandler(this.AddDetail_btn_Click);
            // 
            // goodsBox
            // 
            this.goodsBox.Location = new System.Drawing.Point(68, 45);
            this.goodsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goodsBox.Name = "goodsBox";
            this.goodsBox.Size = new System.Drawing.Size(69, 21);
            this.goodsBox.TabIndex = 26;
            this.goodsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 13F);
            this.label9.Location = new System.Drawing.Point(3, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "商品名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 13F);
            this.label7.Location = new System.Drawing.Point(3, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "数量";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(68, 77);
            this.priceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(68, 21);
            this.priceBox.TabIndex = 27;
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(68, 109);
            this.numberBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(68, 21);
            this.numberBox.TabIndex = 28;
            this.numberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 13F);
            this.label8.Location = new System.Drawing.Point(3, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "单价";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(homework8.Order);
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(homework8.OrderDetail);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 282);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "修改订单";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Addorder_btn;
        private System.Windows.Forms.TextBox customerBox2;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox IDBox2;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IDBox3;
        private System.Windows.Forms.Button AddDetail_btn;
        private System.Windows.Forms.TextBox goodsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
    }
}