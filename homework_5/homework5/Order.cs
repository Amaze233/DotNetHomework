using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemTest
{
    //订单类
    [Serializable]
    public class Order
    {
        public Order()
        {
            Client = new Client();
            Details = new List<OrderDetail>();
        }

        public Order(Client client, List<OrderDetail> details)
        {
            Client = client;
            Details = details;
        }

        //订单详情id号
        private int id = -1;
        
        public int Id
        {
            get
            {
                if (id >= 0)
                    return id;
                else
                    throw new ApplicationException();
            }
                
            set => id = value;
        }

        //客户
        public Client Client { get; set; }

        //订单详情列表
        public List<OrderDetail> Details { get; set; }

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
            return HashCode.Combine(id, Id, Client, Details, SumPrice);
        }
    }

    //异常
    public class NullArgumentException : ApplicationException
    {
        public NullArgumentException(string arg)
            : base($"\"{arg}\" 为空！") { }
        public NullArgumentException() { }
    }
}