using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace homework8
{
    [Serializable]
    public class OrderService
    {

        public List<Order> orderlist = new List<Order>();

        public void Export()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Order>));
            using (FileStream f1 = new FileStream("order.xml", FileMode.Create))
            {
                xml.Serialize(f1, this.orderlist);
            }
            Console.WriteLine("序列化完成");

        }

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

        public List<Order> ShowOrders()
        {
            orderlist.Sort();

            return orderlist;
        }

        public void ModifyOrder(Order order)
        {
            DeleteOrder(order.OrderID);
            orderlist.Add(order);

        }


        public void DeleteOrder(int orderID)
        {
            if (!orderlist.Exists(o => o.OrderID == orderID))
            { throw new Exception($"订单id为{orderID}的订单不存在"); }

            orderlist.RemoveAll(o => o.OrderID == orderID);

        }


        public void AddOrder(Order order)
        {
            if (orderlist.Contains(order))
            {
                throw new Exception($"订单号为{order.OrderID}的订单已存在！");
            }
            else
            {
                orderlist.Add(order);
            }
        }



        public List<Order> SelectByCustomer(string customer)
        {
            var query1 = from order1 in orderlist
                         where order1.Customer.Equals(customer)
                         orderby order1.Money
                         select order1;
            if (query1.ToList().Count == 0) { return null; }
            return query1.ToList();
        }

        public List<Order> SelectByOrderID(int id)
        {
            var query2 = from order2 in orderlist
                         where order2.OrderID == id
                         orderby order2.Money
                         select order2;
            if (query2.ToList().Count == 0) {  return null; }
            return query2.ToList();
        }

        public List<Order> SelectByMoney(double money)
        {
            var query3 = from order3 in orderlist
                         where order3.Money == money
                         select order3;
            if (query3.ToList().Count == 0) { return null; }
            return query3.ToList();
        }

    }

    //单个订单
    [Serializable]
    public class Order : IComparable<Order>
    {
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public string Customer { get; set; }
        public double Money
        {
            get
            {
                double m = 0;
                orderDetails.ForEach(od => m += od.GetallPrice());
                return m;
            }
        }

        public List<OrderDetail> orderDetails = new List<OrderDetail>();


        public Order(int id, string date, string customer)
        {
            this.OrderID = id;
            this.Customer = customer;
            this.OrderDate = date;
        }

        public void AddDetail( OrderDetail orderDetail)
        {
            
            if (orderDetail == null) return;
            else
            {
                if (!orderDetails.Contains(orderDetail))
                {
                   orderDetails.Add(orderDetail);
                }
            }
        }

        public Order() { }


        public override string ToString()
        {
            string order = $"\n订单id：{OrderID}\n订单日期：{OrderDate}\n订单客户：{Customer}\n订单金额：{Money}";
            orderDetails.ForEach(o => order += "\n\t" + o.ToString());
            return order;
        }

        public override bool Equals(Object obj)
        {
            Order order = obj as Order;
            return this.OrderID == order.OrderID && this.OrderDate == order.OrderDate && this.Customer == order.Customer && this.Money == order.Money;

        }

        public override int GetHashCode()
        {
            return OrderID;
        }

        public int CompareTo(Order other)
        {
            Order o = other as Order;
            return this.OrderID - o.OrderID;
            throw new NotImplementedException();
        }
    }

    //明细
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

