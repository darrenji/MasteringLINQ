using System;
using System.Linq;

namespace 有关Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Person[] {
                    new Person("Jane", "jane@foo.com"),
                    new Person("John","john@foo.com"),
                    new Person("Chris", string.Empty)
            };

            var records = new Record[]
            {
                new Record("jane@foo.com","JaneAtFoo"),
                new Record("jane@foo.com","JaneAtHome"),
                new Record("john@foo.com", "John1980")
            };


            var query = people.Join(records,
                    x => x.Email,
                    y => y.Mail,
                    (person, record) => new { Name = person.Name, SkypId = record.SkypeId }
                );

            people.GroupJoin(
                    records,
                    x => x.Email,
                    y => y.Mail,
                    (person, recs) => new {Name = person.Name, SkypIds = recs.Select(r => r.SkypeId).ToArray()}
                );
            
        }
    }

    public class Person
    {
        public string Name, Email;
        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    public class Record
    {
        public string Mail, SkypeId;
        public Record(string mail, string skypeId)
        {
            Mail = mail;
            SkypeId = skypeId;
        }
    }
}