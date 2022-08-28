using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.NewFolder
{
    internal class Customer
    {
        public string name{ get; set; }
        public int age { get; set; }
        public Customer(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        
        }
        public Customer() { }
        public override string ToString()
        {
            return "USer :" + name;
        }
    }
}
