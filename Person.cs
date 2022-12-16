using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsOnList
{
    public class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public Person(string ssn, string name, string address, int age)
        {
            SSN = ssn;
            Name = name;
            Address = address;
            Age = age;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
