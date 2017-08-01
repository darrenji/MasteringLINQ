using System;
using System.Collections.Generic;
using System.Linq;

namespace 分组
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person> {
                    new Person{Name="Adam", Age = 20},
                    new Person{Name="Adam", Age=21},
                    new Person{Name="Alice",Age=25},
                    new Person{Name="Alice", Age=28},
                    new Person{Name="jack",Age=30}
            };

            IEnumerable<IGrouping<string, Person>> byName =   people.GroupBy(p => p.Name);

            //分组的key，还可以是bool类型
            //people.GroupBy(p => p.Age < 30);

            //GroupBy的一个重载方法，定义分组内容
            //people.GroupBy(p => p.Age, p => p.Name);

            foreach(var itemGroup in byName)
            {
                Console.WriteLine(itemGroup.Key);
                foreach(var item in itemGroup)
                {
                    Console.WriteLine("  " + item.Name + ", " + item.Age);
                }
 
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}