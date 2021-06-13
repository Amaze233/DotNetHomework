using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
    //订单详情类
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public OrderDetail()
        {
            Address = "";
            Commodity = new Commodity();
            Count = 1;
        }

        public OrderDetail(string address, Commodity commodity, int count)
        {
            if (address == null || commodity == null)
            {
                /*throw new NullArgumentException();*/
            }
            if (count <= 0)
            {
                throw new InvalidCountException(count);
            }
            Address = address;
            Commodity = commodity;
            Count = count;
        }

        //订单地址
        private string address;

        public string Address
        {
            get => address;
            set
            {
                if (value != null)
                    address = value;
                else
                    throw new InvalidAddressException(address);
            }
        }

        //商品
        public Commodity Commodity { get; set; }

        //商品数量
        private int count;

        public int Count
        {
            get => count;
            set
            {
                if (value >= 0)
                    count = value;
                else
                    throw new InvalidCountException(count);
            }
        }
        public double GetSumPrice()
        {
            return Commodity.Price * count;
        }

        public override string ToString()
        {
            return $"address: {Address}\n" +
                   $"commodity: {Commodity}\n" +
                   $"count: {Count}";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   address == detail.address &&
                   Address == detail.Address &&
                   EqualityComparer<Commodity>.Default.Equals(Commodity, detail.Commodity) &&
                   count == detail.count &&
                   Count == detail.Count;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }


    //数量异常
    public class InvalidCountException : ApplicationException
    {
        public InvalidCountException(int count)
            : base($"{count} 商品数异常！") { }
    }

    //地址异常
    public class InvalidAddressException : ApplicationException
    {
        public InvalidAddressException(string address)
            : base($"{address} 地址异常！") { }
    }
}