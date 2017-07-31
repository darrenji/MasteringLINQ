using System;
using System.Linq;

namespace 过滤
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var evenNumbers = numbers.Where(n => n % 2 == 0);


            //OfType
            object[] values = { 1, 2, 3, 5.2 };
            var intVals = values.OfType<int>();
            foreach(var item in intVals)
                Console.WriteLine(item);

        
        }
    }
}