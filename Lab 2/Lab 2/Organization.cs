using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Organization
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            private set { _ID = value; }
        }
        private string _name;
        public string Name
        { 
            get { return _name; }
            protected set { _name = value; }
        }
        private string _shortName;
        public string ShortName
        {
            get { return _shortName; }
            protected set 
            { 
                _shortName = value;
                ID = value.GetHashCode();
            }
        }
        private string _address;
        public string Address
        {
            get { return _address; }
            protected set { _address = value; }
        }
        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            protected set { _timeStamp = value; }
        }

        public Organization()
        {
            Name = "";
            ShortName = "";
            Address = "";
            TimeStamp = DateTime.Now;
            // ID = GetHashCode();
        }

        public Organization(Organization organization)
        {
            Name = organization.Name;
            ShortName = organization.ShortName;
            Address = organization.Address;
            TimeStamp = organization.TimeStamp;
            // ID = organization.ID;
        }

        public Organization(string name, string shortName, string address)
        {
            Name = name;
            ShortName = shortName;
            Address = address;
            TimeStamp = DateTime.Now;
            // ID = GetHashCode();
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{ShortName}, {Name}, {Address}, {TimeStamp}, {ID}");
        }

        public override int GetHashCode()
        {
            return ShortName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Organization organiztion)
            {
                return organiztion.ID == ID;
            }

            return false;
        }
    }
}
