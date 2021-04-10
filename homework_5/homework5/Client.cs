namespace homework5
{
    //客户类
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public Client()
        {
            this.Id = 0;
            this.Name = "";
            this.Address = "";
            this.PhoneNumber = 0;
        }

        public Client(int id,string name, string address, int phoneNumber)
        {
            this.Address = address;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Id = id;
        }

        public override string ToString()
        {
            return $"Name:{this.Name} \t PhoneNumber{this.PhoneNumber} \t Address{this.Address}";
        }

        protected bool Equals(Client other)
        {
            return Name == other.Name && Address == other.Address && PhoneNumber == other.PhoneNumber;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Client) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Address != null ? Address.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ PhoneNumber;
                return hashCode;
            }
        }
    }
}