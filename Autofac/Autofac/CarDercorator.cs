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
            logger.Info("Break");
            car.Break();
        }

        public void SpeedUp()
        {
            logger.Info("speed Up");
            car.SpeedUp();
        }

        public void TurnLeft()
        {
            logger.Info("TurnLeft");
            car.TurnLeft();
        }

        public void TurnRight()
        {
            logger.Info("TurnRight");
            car.TurnRight();
        }
    }
}
