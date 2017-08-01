using System;
using System.Linq;

namespace 分区
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 3, 5, 6, 7 };
            numbers.Skip(2).Take(5);
            numbers.SkipWhile(i => i == 3);
            numbers.TakeWhile(i => i > 1);
        }
    }
}