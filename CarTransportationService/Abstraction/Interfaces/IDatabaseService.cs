using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Request;
using CarTransportationService.Requesting_Information.Trailer_Details;

namespace CarTransportationService.Abstraction.Interfaces
{
    interface IDatabaseService
    {
        CalculationModel ConstructCalculationModel(UserRequest userRequest);
    }
}
