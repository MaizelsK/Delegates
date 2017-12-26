using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    abstract public class Car
    {
        public string Model { get; set; }
        public double Distance { get; set; }
        public double Speed { get; set; }

        public void Ride()
        {
            Random speedChange = new Random();

            // Постоянная смена скорости
            Distance += (Speed + speedChange.Next(-3, 6));
        }
    }
}
