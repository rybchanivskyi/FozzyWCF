using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FozzyWCF
{
    public class CelsiusToFahrenheit : ICelsiusToFahrenheit
    {
        public double ConvertToFahrenheit(double celsius)
        {
            Console.WriteLine($"Start converting {celsius} Celsius to Fahrenheit");
            return (celsius * 9 / 5) + 32;
        }
    }
}
