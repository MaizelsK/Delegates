using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private List<string> stock;

        public void AddToStock(string item)
        {
                stock.Add(item);
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
