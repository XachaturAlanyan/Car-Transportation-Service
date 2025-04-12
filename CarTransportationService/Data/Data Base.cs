using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Abstraction.Implementation;
using CarTransportationService.Request;
using CarTransportationService.Requesting_Information.Car_Details;
using CarTransportationService.Requesting_Information.Destination;
using CarTransportationService.Requesting_Information.Trailer_Details;

namespace CarTransportationService.Data
{
    internal class Data_Base
    {
        Repository<CarDetails> CarDetailsRepository { get; set; }
        Repository<CarOperable> CarOperableRepository { get; set; }
        Repository<CarType> CarTypeRepository { get; set; }

        Repository<Route> RouteRepository { get; set; }

        Repository<TrailerType> TrailerRepository { get; set; }

        public float GetCoefficient(UserRequest request)
        {
            float coefficient = 1;
            var item = CarOperableRepository.GetItem(x => x.IsOperable == request.CarOperable.IsOperable);
            coefficient *= item.Coefficient;
            var item1 = CarTypeRepository.GetItem(x => x.VehicleType.Equals(request.CarType.VehicleType));
            coefficient *= item1.Coefficient;
            var item2 = RouteRepository.GetItem(x=> x.From == request.route.From &&  x.To == request.route.To);
        }
    }   
}
