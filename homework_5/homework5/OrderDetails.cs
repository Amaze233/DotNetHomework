using System;

namespace homework5
{
    //订单明细类
    public class OrderDetails
    {
        public int Amount { get; set; }
        public Commodity Commodity { get; set; }
        public Client Client { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public OrderDetails()
        {
            this.Address = "";
            this.Amount = 1;
            this.PhoneNumber = 0;
            this.Commodity = new Commodity();
            this.Client = new Client();
        }

        public OrderDetails(Commodity commodity,int amount,Client client)
        {
            if (commodity == null )
            {
                Console.WriteLine("商品为空！！");
            }
            if (client == null )
            {
                Console.WriteLine("用户为空！！");
            }

            if (amount <= 0)
            {
                Console.WriteLine("商品数量不正确！！");
            }
            
            this.Amount = amount;
            this.Commodity = commodity;
            this.Client = client;
            this.Address = client.Address;
            this.PhoneNumber = 0;
            
        }

        public override string ToString()
        {
            return $"CommodityName:{Commodity.Name} \t Amount:{this.Amount} \t ClientName:{Client.Name} \t ClientAddress:{Address} \t ClientPhoneNumber:{PhoneNumber} ";
        }
    }
}