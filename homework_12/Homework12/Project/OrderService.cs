using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Homework12
{
    [Serializable]
    public class OrderService
    {

        public List<Order> Orders = new List<Order>();

        //序列化
        public void Export()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Order>));
            using (FileStream f1 = new FileStream("order.xml", FileMode.Create))
            {
                xml.Serialize(f1, this.Orders);
            }
            Console.WriteLine("序列化完成");

        }

        //反序列化
        public void Import()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Order>));
            using (FileStream f1 = new FileStream("order.xml", FileMode.Open))
            {
                List<Order> orders = (List<Order>)xml.Deserialize(f1);
                foreach (Order o in orders)
                {
                    Console.WriteLine(o);
                }
                Console.WriteLine("反序列化完成");
            }
        }


        public OrderService() { }

        //展示订单列表
        public List<Order> ShowOrders()
        {
            Orders.Sort();

            return Orders;
        }

        //修改订单
        public void ChangeOrder(Order order)
        {
            DeleteOrder(order.OrderID);
            Orders.Add(order);

        }

        //删除订单
        public void DeleteOrder(int orderID)
        {
            if (!Orders.Exists(order => order.OrderID == orderID))
            { 
                throw new Exception($"订单id为{orderID}的订单不存在"); 
            }

            Orders.RemoveAll(o => o.OrderID == orderID);

        }

        //添加订单
        public void AddOrder(Order order)
        {
            if (Orders.Contains(order))
            {
                throw new Exception($"订单号为{order.OrderID}的订单已存在！");
            }
            else
            {
                Orders.Add(order);
            }
        }


        //按客户名查询
        public List<Order> SelectByCustomer(string customer)
        {
            var query = from order in Orders
                         where order.Customer.Equals(customer)
                         orderby order.Money
                         select order;
            if (query.ToList().Count == 0) { return null; }
            return query.ToList();
        }

        //按订单id查询
        public List<Order> SelectByOrderID(int id)
        {
            var query = from order in Orders
                         where order.OrderID == id
                         orderby order.Money
                         select order;
            if (query.ToList().Count == 0) {  return null; }
            return query.ToList();
        }

        //按总额查询
        public List<Order> SelectByMoney(double money)
        {
            var query3 = from order3 in Orders
                         where order3.Money == money
                         select order3;
            if (query3.ToList().Count == 0) { return null; }
            return query3.ToList();
        }

    }



    

    /*//明细
    [Serializable]
    public class OrderDetail
    {
        public string Goodsname { get; set; }
        public double Price { get; set; }
        private int number;
        public int Number
        {
            get => number;
            set
            {
                if (value < 0) Console.WriteLine("输入不合法");
                else number = value;
            }
        }
        public OrderDetail(string goodsname, double price, int number)
        {
            this.Goodsname = goodsname;
            this.number = number;
            this.Price = price;
        }
        public OrderDetail() { }

        public double GetallPrice()
        {
            return Price * number;
        }

        public override string ToString()
        {
            return $"商品名称：{Goodsname}\n\t单价：{Price}\n\t数量：{number}\n\t总金额：{GetallPrice()}";
        }

        public override bool Equals(Object obj)
        {
            OrderDetail orderdetail = obj as OrderDetail;
            return this.Goodsname == orderdetail.Goodsname && this.Price == orderdetail.Price && this.Number == orderdetail.Number;

        }

        
    }*/
}

