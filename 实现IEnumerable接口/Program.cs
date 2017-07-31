using System;
using System.Collections;
using System.Collections.Generic;

namespace 实现IEnumerable接口
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Params(1, 3, 5);
            Console.WriteLine("开始遍历Params");
            foreach(var x in p)
            {
                Console.WriteLine(x);
            }

            var person = new Person("daren", "ji", "china");
            Console.WriteLine("开始遍历Person的Names属性");
            foreach(var name in person.Names)
            {
                Console.WriteLine(name);
            }
        }
    }

    public class Params : IEnumerable<int>
    {
        private int a, b, c;

        public Params(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield return c;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Person
    {
        private string firstName, middleName, lastName;
        public Person(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public IEnumerable<string> Names
        {
            get
            {
                yield return firstName;
                yield return middleName;
                yield return lastName;
            }
        }

    }
}