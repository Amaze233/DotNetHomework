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
    public partial class Form1 : Form
    {
        public OrderService service = new OrderService();
        public List<Order> orders = new List<Order>();
        public List<Order> orders2 = new List<Order>();
        public List<OrderDetail> orderDetails = new List<OrderDetail>();
        public int OrderID { get; set; }
        public string Customer { get; set; }

        public string Date { get; set; }
        public Form1()
        {
            //设置一些商品
            Commodity commodity1 = new Commodity("香蕉", 3.0);
            Commodity commodity2 = new Commodity("笔", 2.5);
            Commodity commodity3 = new Commodity("书", 20.0);
            Commodity commodity4 = new Commodity("蛋", 2.0);
            Commodity commodity5 = new Commodity("西红柿", 4.0);
            Commodity commodity6 = new Commodity("洋葱", 3.5);

            //设置用户


            OrderDetail od1 = new OrderDetail("北京", commodity1, 4);
            OrderDetail od2 = new OrderDetail("北京", commodity2, 6);
            OrderDetail od3 = new OrderDetail("上海", commodity3, 1);
            OrderDetail od4 = new OrderDetail("上海", commodity4, 4);
            OrderDetail od5 = new OrderDetail("武汉", commodity5, 2);
            OrderDetail od6 = new OrderDetail("武汉", commodity6, 5);

            Order order1 = new Order(1, "十月一日", "小明");
            Order order2 = new Order(3, "十月五日", "小明");
            Order order3 = new Order(2, "十一月一日", "小洪");
            Order order4 = new Order(5, "一月二十", "杜克");
            Order order5 = new Order(8, "一月五日", "杜克");

            order1.orderDetails.Add(od1);
            order1.orderDetails.Add(od2);
            order2.orderDetails.Add(od3);
            order3.orderDetails.Add(od4);
            order3.orderDetails.Add(od5);
            order4.orderDetails.Add(od6);
            order5.orderDetails.Add(od6);
            List<Order> orders = new List<Order>();
            { orders.Add(order1); orders.Add(order2); orders.Add(order3); orders.Add(order4); orders.Add(order5); }
            service.Orders = orders;
            InitializeComponent();
            IDBox4.DataBindings.Add("Text", this, "OrderID");
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex == -1) { return; }
            else
            {
                DataGridViewCell cell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell == null || cell.Value.ToString() == "" || cell.Value.ToString() == "0") { return; }
                else
                {
                    OrderID = Int32.Parse(cell.Value.ToString());
                    var query = service.Orders.Where(o => o.OrderID == OrderID);
                    Order order = query.FirstOrDefault();
                    dataGridView2.DataSource = order.orderDetails;
                }
            }
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
           
            orders = service.ShowOrders();
            dataGridView1.DataSource = orders;

        }

        private void Addorder_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                Order order = form2.Tag as Order;
                service.AddOrder(order);
                //List<Order> orders = new List<Order>();
                //service.orderlist.ForEach(o => orders.Add(o));
                dataGridView1.Refresh();
                dataGridView1.DataSource = service.Orders;
            }
        }




        private void delete_btn_Click(object sender, EventArgs e)
        {
            service.DeleteOrder(OrderID);
            List<Order> orders = new List<Order>();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                var order = row.DataBoundItem as Order;
                if (order != null)
                {
                    orders.Add(order);
                }
            }
            dataGridView1.DataSource = orders;
        }

        private void AddDetail_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                OrderDetail orderDetail = form2.Tag as OrderDetail;
                var query = service.Orders.Where(o => o.OrderID == form2.OrderID);
            
            Order order = query.FirstOrDefault();
                if (order == null) return;
                else
                {
                    order.AddDetail(orderDetail);
                }

            dataGridView1.DataSource = service.Orders;
            }
        }   

        private void select_btn_Click(object sender, EventArgs e)
        {
            switch (selectcomboBox.SelectedIndex) 
            {
                case 0: orders = service.SelectByOrderID(Int32.Parse( selectBox.Text));break;
                case 1:orders = service.SelectByCustomer(selectBox.Text);break;
                case 3:orders = service.SelectByMoney(Convert.ToDouble(selectBox.Text));break;
                default:break;
             }
            dataGridView1.DataSource = orders;
        }

       

        private void modifyOrder_btn_Click_1(object sender, EventArgs e)
        {
            Form2 userDialog = new Form2();
            if (userDialog.ShowDialog() == DialogResult.OK)
            {
                Order order = userDialog.Tag as Order;
                service.ChangeOrder(order);
               
            }
            dataGridView1 .DataSource = service.ShowOrders();
        }

        private void addOrder_btn_Click_1(object sender, EventArgs e)
        {
            Form2 userDialog = new Form2();
            if (userDialog.ShowDialog() == DialogResult.OK)
            {
                Order order = userDialog.Tag as Order;
                service.AddOrder(order);
                List<Order> temp_list = new List<Order>();
                service.Orders.ForEach(o => temp_list.Add(o));
                dataGridView1.DataSource = temp_list;
            }
        }

        private void IDBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
