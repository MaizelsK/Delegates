using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class Taxation
    {
        public static void GetTax(Person person, double price)
        {
            double tax = price / 5;

            Console.WriteLine($"{person.Name} заплатил налог в размере {tax} тенге");
            Console.ReadLine();
        }
    }
}
