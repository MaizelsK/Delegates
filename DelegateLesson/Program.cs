﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BankAccount account = new BankAccount();
            account.Add(100);
            account.RegisterHadler(new AccountOperationsHandler(PrintMessage));

            account.Add(200);*/

            Forex forex = new Forex();

            Person person1 = new Person("Kirill", 20);

            forex.BuyItem(person1, "Sofa");
        }
    }
}
