using Autofac.Extras.NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac
{
    class Car : ICar
    {
        ILogger logger;
        public Car(ILogger logger)
        {
            this.logger = logger;
        }
        public void Break()
        {
            Console.WriteLine("Break");
        }

        public void SpeedUp()
        {
            Console.WriteLine("SpeedUp");
        }

        public void TurnLeft()
        {
            Console.WriteLine("TurnLef");
        }

        public void TurnRight()
        {
            Console.WriteLine("TurnRight");

        }
    }
}
