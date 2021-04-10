using System;
using System.Collections.Generic;
using System.Text;

namespace homework5
{
    //订单类
    public class Order
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        //订单列表
        public List<OrderDetails> OrderDetailsList { get; set; }
        
        public Order()
        {
            Client = new Client();
            OrderDetailsList = new List<OrderDetails>();
        }

        public Order(Client client, List<OrderDetails> orderDetailsList)
        {
            if (client == null )
            {
                Console.WriteLine("用户为空！！");
            }
            if (orderDetailsList == null )
            {
                Console.WriteLine("商品为空！！");
            }
            this.Client = client;
            this.OrderDetailsList = orderDetailsList;
        }

        public int TotalPrice
        {
            get
            {
                int TotalPrice = 0;
                foreach (var orderDetails in OrderDetailsList)
                {
                    TotalPrice += orderDetails.Commodity.Price * orderDetails.Amount;
                }
                return TotalPrice;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"id: {Id}\t");
            sb.Append($"client: {Client}\t");
            sb.Append($"total price: {TotalPrice}\t");
            sb.Append("details:\t");
            foreach (var orderDetails in OrderDetailsList)
            {
                sb.Append($"{OrderDetailsList}\t");
            }
            sb.Append("\n");
            return sb.ToString();
        }

        protected bool Equals(Order other)
        {
            return Equals(Client, other.Client) && Equals(OrderDetailsList, other.OrderDetailsList);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Order) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Client != null ? Client.GetHashCode() : 0) * 397) ^ (OrderDetailsList != null ? OrderDetailsList.GetHashCode() : 0);
            }
        }
    }
    
}