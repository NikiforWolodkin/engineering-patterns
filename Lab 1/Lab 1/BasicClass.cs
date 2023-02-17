using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_1
{
    public class BasicClass
    {
        public const int PublicConst = 4;
        protected const int ProtectedConst = 8;
        private const int _privateConst = 16;
        public int PublicField;
        protected int ProtectedField;
        private int _privateField;
        public int PublicProperty { get; set; }
        protected int ProtectedProperty { get; set; }
        private int _privateProperty { get; set; }

        public BasicClass()
        {
            PublicField = PublicConst;
            ProtectedField = ProtectedConst;
            _privateField = _privateConst;
            PublicProperty = PublicConst;
            ProtectedProperty = ProtectedConst;
            _privateProperty = _privateConst;
        }

        public BasicClass(BasicClass basicClass)
        {
            PublicField = basicClass.PublicField;
            ProtectedField = basicClass.ProtectedField;
            _privateField = basicClass._privateField;
            PublicProperty = basicClass.PublicProperty;
            ProtectedProperty = basicClass.ProtectedProperty;
            _privateProperty = basicClass._privateProperty;
        }

        public BasicClass(int publicField, int protectedField, int privateField,
                          int publicProperty, int protectedProperty, int privateProperty)
        {
            PublicField = publicField;
            ProtectedField = protectedField;
            _privateField = privateField;
            PublicProperty = publicProperty;
            ProtectedProperty = protectedProperty;
            _privateProperty = privateProperty;
        }

        public void PrintMembers()
        {
            Console.WriteLine($"{PublicConst}, {ProtectedConst}, {_privateConst}");
            Console.WriteLine($"{PublicField}, {ProtectedField}, {_privateField}");
            Console.WriteLine($"{PublicProperty}, {ProtectedProperty}, {_privateProperty}");
        }

        public void PrintPublic()
        {
            Console.WriteLine("I'm a public method");
        }

        protected void PrintProtected()
        {
            Console.WriteLine("I'm a protected method");
        }

        private void PrintPrivate()
        {
            Console.WriteLine("I'm a private method");
        }

        public void CallPrivateAndProtectedMethods()
        {
            PrintProtected();
            PrintPrivate();
        }
    }
}
