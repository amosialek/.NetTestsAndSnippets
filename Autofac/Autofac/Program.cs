using Autofac.Extras.NLog;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<NLogModule>();
            builder.RegisterType<Car>().As<ICar>();
            builder.RegisterDecorator(typeof(CarDecorator), typeof(ICar));
            var Container = builder.Build();
            using (var scope = Container.BeginLifetimeScope())
            {
                var car = scope.Resolve<ICar>();
                car.SpeedUp();
                Console.ReadLine();
            }
        }
    }
}
