using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FozzyWCF
{
    [ServiceContract]
    public interface ICelsiusToFahrenheit
    {
        [OperationContract]
        double ConvertToFahrenheit(double celsius);
    }
}
