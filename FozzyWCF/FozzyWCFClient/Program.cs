using FozzyWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FozzyWCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";
            Type serviceType = typeof(CelsiusToFahrenheit);
            using (ServiceHost host = new ServiceHost(serviceType))
            {
                host.Open();

                Console.WriteLine("Host Started!");
                Console.ReadLine();

            }
        }
    }
}
