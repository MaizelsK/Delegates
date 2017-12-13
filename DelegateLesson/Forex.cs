using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public delegate void ForexOpeartions(Person person, double price);
    public class Forex
    {
        private ForexOpeartions operationsHandler;

        private Dictionary<string, double> forexStock = new Dictionary<string, double>();

        private List<Person> users = new List<Person>();

        public void AddUser(Person person)
        {
            users.Add(person);
        }

        public Forex()
        {
            operationsHandler = new ForexOpeartions(Taxation.GetTax);

            forexStock.Add("Apple", 150);
            forexStock.Add("Google", 200);
            forexStock.Add("AstanaBank", 100);
            forexStock.Add("Bitcoin", 10000);
        }

        public void BuyItem(Person person, string item)
        {
            //person.AddToStock(forexStock[])
        }

        public void SellItem(Person person, string item)
        {
            //forexStock.Add(item, price);
            if (forexStock.ContainsKey(item))
            {
                person.Money += forexStock[item];

                operationsHandler.Invoke(person, forexStock[item]);
            }
        }
    }
}
