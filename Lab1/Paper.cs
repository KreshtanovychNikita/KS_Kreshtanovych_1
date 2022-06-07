using Lab1.general;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Info
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public Person Person { get; set; }
       

        public Info()
        {
            Name = string.Empty;
            Person = new Person();
            Date = DateTime.Now;
        }

        public Info(string name, Person person, DateTime dateTime)
        {
            Name = name;
            Person = person;
            Date = dateTime;
        }

        public override string? ToString()
        {
            return $"Name : {Name}, Person: {Person}, Date: {Date.ToString("d")}";
        }
    }
}
