using System;
using System.Collections.Generic;
using System.Linq;

namespace 排序
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var randValues = Enumerable.Range(1, 10)
                .Select(_ => rand.Next(10) - 5);

            var enumerableToString = new Func<IEnumerable<int>, string>(values =>
            {
                    return string.Join(",", values.Select(v => v.ToString()).ToArray());
            });

            Console.WriteLine(enumerableToString(randValues));
            Console.WriteLine(enumerableToString(randValues.OrderBy(x => x)));


            var people = new List<Person> {
                new Person{Name = "Adam", Age=35},
                new Person{Name="darren",Age=38},
                new Person{Name="sunny",Age=28}
            };

            IOrderedEnumerable<Person> sortedPeople = people.OrderBy(p => p.Name);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}