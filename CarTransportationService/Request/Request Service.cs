using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Abstraction.Implementation;
using CarTransportationService.Requesting_Information.Car_Details;
using CarTransportationService.Requesting_Information.Destination;
using CarTransportationService.Requesting_Information.Trailer_Details;

namespace CarTransportationService.Request
{
    internal class Request_Service
    {

        public float GetTotalCoefficient(UserRequest request, 
            Repository<CarOperable> operableRep, 
            Repository<CarType> typeRep,
            Repository<Route> routeRep,
            Repository<TrailerType> trailerRep) 
        {
            
        }

    }
}
