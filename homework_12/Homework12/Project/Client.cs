using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    // 客户类 
    public class Client
    {
        public Client()
        {
            Name = "";
            PhoneNumber = 0;
        }

        public Client(string name, int phonenumber)
        {
            this.Name = name;
            this.PhoneNumber = phonenumber;
        }

        //姓名
        private string name;
        
        public string Name { get ; set; }
        
        // 电话号码
        private int phonenumber;
        
        public int PhoneNumber
        {
            get => phonenumber;
            set
            {
                if (value >= 0)
                    phonenumber = value;
                else
                    throw new InvalidPhoneException(value);
            }
        }

        public override string ToString()
        {
            return $"name: {Name}, phonenumber: {PhoneNumber}";
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   name == client.name &&
                   Name == client.Name &&
                   phonenumber == client.phonenumber &&
                   PhoneNumber == client.PhoneNumber;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

    // 电话异常
    class InvalidPhoneException : ApplicationException
    {
        public InvalidPhoneException(int phonenumber)
            : base($"\"{phonenumber}\" 电话异常！") { }
    }
}
