using System;
using System.Collections.Generic;
using System.Linq;

namespace 转换数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new List<int>() { 1, 3, 3 };
            //Console.WriteLine(list.Sum());

            //IEnumerable转换成其它集合类型
            var numbers = Enumerable.Range(1, 10);
            var arr = numbers.ToArray();
            var dict = numbers.ToDictionary(i => (double)i / 10, i => i % 2 == 0);
            foreach(var item in dict)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            //其它集合类型转换成IEnumerable
            var arr2 = new[] { 1, 2, 3 };
            IEnumerable<int> arrs = arr2.AsEnumerable();
        }
    }
}