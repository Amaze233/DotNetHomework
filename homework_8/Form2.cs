using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework8
{
    public partial class Form2 : Form
    {
        public int OrderID { get; set; }
        public string Customer { get; set; }
        public string Date { get; set; }

        public string Goodsname { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public Form2()
        {
            InitializeComponent();

            
            IDBox2.DataBindings.Add("Text", this, "OrderID");
            dateBox.DataBindings.Add("Text", this, "Date");
            customerBox2.DataBindings.Add("Text", this, "Customer");

            IDBox3.DataBindings.Add("Text", this, "OrderID");
            goodsBox.DataBindings.Add("Text", this, "Goodsname");
            priceBox.DataBindings.Add("Text", this, "Price");
            numberBox.DataBindings.Add("Text", this, "Number");

            
        }

        private void Addorder_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Order order = new Order(OrderID, Date, Customer);
            this.Tag = order;
        }

        private void AddDetail_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            OrderDetail orderDetail = new OrderDetail(Goodsname, Price, Number);
            this.Tag = orderDetail;
        }
    }
}
