using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Request;

namespace CarTransportationService.Abstraction.Interfaces
{
    interface ICalculationService
    {
        float Calculate(CalculationModel calculationModel);
    }

}
