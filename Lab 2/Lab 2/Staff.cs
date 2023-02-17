using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class StaffObject
    {
        public string Name;

        public StaffObject(string name)
        {
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            if (obj is StaffObject staffObj)
            {
                return staffObj.Name == Name;
            }

            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class JobVacancy : StaffObject
    { 
        public JobVacancy(string name) : base(name) { }
    }

    public class JobTitle : StaffObject
    {
        public JobTitle(string name) : base(name) { }
    }

    public class Person : StaffObject
    {
        public Person(string name) : base(name) { }
    }

    public class Employee : StaffObject
    {
        public JobTitle Title;

        public Employee(Person person, JobVacancy vacancy) : base(person.Name)
        {
            Title = new JobTitle(vacancy.Name);
        }
    }

    public class Department : StaffObject
    {
        public Department(string name) : base(name) { }
    }
}
