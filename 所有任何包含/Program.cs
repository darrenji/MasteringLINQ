using System;
using System.Linq;

namespace 所有任何包含
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 5, 6 };
            Console.WriteLine("all numbers >0? " + numbers.All(x => x > 0));
            Console.WriteLine("are all numbers odd? " + numbers.All(x => x%2==1));
            Console.WriteLine("any number < 2? " + numbers.Any(x => x <2));
            Console.WriteLine("contains 6? " + numbers.Contains(6));

            //Any还可以用来判断一个集合中是否有值
            Console.WriteLine(new int[] { 3}.Any());
        }
    }
}