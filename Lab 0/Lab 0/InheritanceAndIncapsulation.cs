using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0
{
    public class User
    {
        public string Name { get; set; }
        private int _ID { get; set; }

        public User(string name)
        {
            Name = name;
            _ID = name.GetHashCode();
        }

        public string GenerateToken()
        {
            return $"{_ID} {DateTime.Now.GetHashCode()}";
        }
    }

    public class Client : User
    {
        public List<string> Orders { get; set; }

        public Client(string name) : base(name)
        {
            Orders = new List<string>();
        }

        public void Order(string item)
        {
            Orders.Add($"Token:{GenerateToken()}; Item:{item}");
        }
    }

    public class Admin : User
    {
        public int Price { get; set; }

        public Admin(string name, int price) : base(name)
        {
            Price = price;
        }

        public void SetPrice(int price)
        {
            Price = price;
        }
    }
}
