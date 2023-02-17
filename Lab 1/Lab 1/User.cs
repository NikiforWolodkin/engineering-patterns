using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_1
{
    public class User
    {
        public string Name { get; set; }
        protected int Age { get; set; }
        private string _ID { get; set; }

        public User()
        {
            Name = "";
            Age = 0;
            _ID = GenerateID("", 0);
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
            _ID = GenerateID(name, age);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}, {_ID}, {Age}");
        }

        private string GenerateID(string name, int age)
        {
            return name.GetHashCode().ToString() + age.GetHashCode().ToString();
        }
    }

    public class Student : User
    { 
        public string Faculty { get; set; }
        public bool IsStudying { get; private set; }
        
        public Student() : base()
        {
            Faculty = "";
            IsStudying = true;
        }

        public Student(string name, int age, string faculty) : base(name, age)
        {
            Faculty = faculty;
            IsStudying = true;
        }

        public bool Expell()
        {
            if (IsStudying)
            {
                IsStudying = false;
                return true;
            }

            return false;
        }
    }
}
