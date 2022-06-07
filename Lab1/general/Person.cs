using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.general
{
    internal class Person
    {
        private string _name;
        private string _surname;
        private DateTime _bornDate;

 
        public DateTime BornDate { get => _bornDate; init => _bornDate = value; }
        public int YearBornDate { get => _bornDate.Year; init =>_bornDate = new DateTime(value,_bornDate.Month,_bornDate.Day); }
        public string Name { get => _name; init => _name = value; }
        public string Surname { get => _surname; init => _surname = value; }
       

        public Person()
        {
            _name = string.Empty;
            _surname = string.Empty;
            _bornDate = DateTime.Now;
        }
       

       
        public string? ToShortString()
        {
            return $"{_name} {_surname}";
        }
        public override string? ToString()
        {
            return $"Name: {_name}, Surname: {_surname}, BornDate: {_bornDate.ToString("d")}";
        }
        public Person(string name, string surname, DateTime bornDate)
        {
            _name = name;
            _surname = surname;
            _bornDate = bornDate;
        }
    }
}
