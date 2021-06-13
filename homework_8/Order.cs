using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
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
                double money = 0;
                orderDetails.ForEach(od => money += od.GetSumPrice());
                return money;
            }
        }

        public List<OrderDetail> orderDetails = new List<OrderDetail>();


        public Order(int id, string date, string customer)
        {
            this.OrderID = id;
            this.Customer = customer;
            this.OrderDate = date;
        }

        public void AddDetail(OrderDetail orderDetail)
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
    /*public class Order
    {
        public Order()
        {
            Client = new Client();
            Details = new List<OrderDetail>();
        }

        public Order(int id, string date, Client client)
        {
            id =
            Client = client;
            OrderDate = date;
        }

        //订单id
        public int ID { get; set; }

        //客户
        public Client Client { get; set; }

        //下单时间
        public string OrderDate { get; set; }

        //总价
        public double SumPrice
        {
            get
            {
                double sum = 0;
                Details.ForEach(detail => sum += detail.Commodity.Price * detail.Count);
                return sum;
            }
        }

        //是否包括商品
        public bool ContainsCommodity(Commodity commodity) =>
            Details.Find(detail => detail.Commodity.Equals(commodity)) != null;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"id: {Id}\n\n")
              .Append($"client:\n{Client}\n\n")
              .Append($"price sum: {SumPrice}\n\n")
              .Append("details:\n");
            Details.ForEach(detail => sb.Append($"{detail}\n"));
            sb.Append("\n");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   id == order.id &&
                   Id == order.Id &&
                   EqualityComparer<Client>.Default.Equals(Client, order.Client) &&
                   EqualityComparer<List<OrderDetail>>.Default.Equals(Details, order.Details) &&
                   SumPrice == order.SumPrice;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }*/

    //异常
    public class NullArgumentException : ApplicationException
    {
        public NullArgumentException(string arg)
            : base($"\"{arg}\" 为空！") { }
        public NullArgumentException() { }
    }
}
