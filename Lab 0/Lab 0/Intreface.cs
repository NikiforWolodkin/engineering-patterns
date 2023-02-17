using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0
{
    public interface ISum
    {
        int Sum();
    }

    public class ListContainer : ISum
    {
        public List<int> List { get; set; }

        public ListContainer(params int[] items)
        {
            List = new List<int>(items);
        }

        public int Sum() => List.Sum();
    }

    public class ArrayContainer : ISum
    {
        public int[] Array { get; set; }

        public ArrayContainer(params int[] items)
        {
            Array = items;
        }

        public int Sum() => Array.Sum();
    }

    public class ValueContainer : ISum
    {
        public int Value { get; set; }
        public int AdditionalValue { get; set; }

        public ValueContainer(int value, int additionalValue)
        {
            Value = value;
            AdditionalValue = additionalValue;
        }

        public int Sum() => Value + AdditionalValue;
    }
}
