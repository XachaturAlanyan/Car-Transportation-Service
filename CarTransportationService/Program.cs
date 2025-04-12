using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Abstraction.Implementation;
using CarTransportationService.Requesting_Information.Car_Details;
using CarTransportationService.Requesting_Information.Destination;
using CarTransportationService.Requesting_Information.Trailer_Details;

namespace CarTransportationService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<CarDetails> _carDetailsRep = new Repository<CarDetails>();
            _carDetailsRep.Add(new CarDetails("Bmw", 2020));

            _carDetailsRep.Update()
            Repository<CarOperable> _carOperableRep = new Repository<CarOperable>();
            Repository<CarType> _carTypeRep = new Repository<CarType>();
            Repository<Route> _routeRep = new Repository<Route>(); 
            Repository<TrailerType> _trailerRep = new Repository<TrailerType>();

        }
    }
}
