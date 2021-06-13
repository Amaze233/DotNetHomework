using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemTest
{
    //商品类
    public class Commodity
    {
        public Commodity()
        {
            Name = "";
            Price = 0;
        }

        public Commodity(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //商品名
        public string Name { get; set; }

        //价格
        private double price;

        public double Price
        {
            get => price;
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new InvalidPriceException(value);
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }

        public override bool Equals(object obj)
        {
            return obj is Commodity commodity &&
                   Name == commodity.Name &&
                   price == commodity.price &&
                   Price == commodity.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, price, Price);
        }
    }
    
    //价格异常
    public class InvalidPriceException : ApplicationException
    {
        public InvalidPriceException(double price)
            : base($"{price} 价格异常！") { }
    }
}