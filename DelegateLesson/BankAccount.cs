using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DelegateLesson
{
    public delegate void AccountOperationsHandler(string message);
    public class BankAccount
    {
        private AccountOperationsHandler handler;
        public double Sum { get; private set; }

        public void RegisterHadler(AccountOperationsHandler handler)
        {
            this.handler += handler;
        }
        public void UnRegisterHadler(AccountOperationsHandler handler)
        {
            this.handler -= handler;
        }

        public void Add(int sum)
        {
            Sum += sum;
            if (handler != null)
            {
                handler.Invoke("Вы добавили " + sum);
            }
        }

        public void WithDraw(int sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;
                if (handler != null)
                {
                    handler.Invoke("Вы cняли " + sum);
                }
            }

            if (handler != null)
            {
                handler.Invoke("У вас недостаточно средств");
            }
        }
    }
}