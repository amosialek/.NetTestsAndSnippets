using Autofac.Extras.NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac
{
    public class CarDecorator : ICar
    {
        public CarDecorator(ICar car, ILogger logger)
        {
            this.car = car;
            this.logger = logger;
        }
        
        private ICar car;
        private ILogger logger;
        public void Break()
        {
            car.Break();
        }

        public void SpeedUp()
        {
            logger.Info("speed Up");
            car.SpeedUp();
            Console.WriteLine("speed up");
        }

        public void TurnLeft()
        {
            car.TurnLeft();
        }

        public void TurnRight()
        {
            car.TurnRight();
        }
    }
}
