using System;

namespace homework5
{
    //商品类
    public class Commodity
    {
        
        public string Name { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }

        public Commodity()
        {
            this.Name = "";
            this.Price = 0;
        }

        public Commodity(string name, int price)
        {
            this.Name = name;
            if (price >= 0)
            {
                this.Price = price;
            }
            else
            {
                Console.WriteLine("商品金额出错！");
            }
        }

        public override string ToString()
        {
            return $"Name:{this.Name} \t Price{this.Price}";
        }

        protected bool Equals(Commodity other)
        {
            return Name == other.Name && Price == other.Price;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Commodity) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ Price;
            }
        }
    }
}