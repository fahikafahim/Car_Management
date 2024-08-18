using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TelephoneNo { get; set; }

        protected Person(string id, string name, string telephoneNo)
        {
            Id = id;
            Name = name;
            TelephoneNo = telephoneNo;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Telephone Number: {TelephoneNo}";
        }
    }
}
