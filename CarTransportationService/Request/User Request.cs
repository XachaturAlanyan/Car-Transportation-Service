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
    internal class UserRequest
    {

        public int Id { get; set; }

        public CarDetails CarDetails { get; set; }

        public CarType CarType { get; set; }

        public CarOperable CarOperable { get; set; }
        public TrailerType TrailerType { get; set; }
        
        public Route route { get; set; }

        public Trailer Trailer { get; set; }

        public UserRequest(int id, CarDetails carDetails, CarOperable carOperable, TrailerType trailerType, Route route, Trailer trailer, CarType carType)
        {
            Id = id;
            CarDetails = carDetails;
            CarOperable = carOperable;
            TrailerType = trailerType;
            this.route = route;
            Trailer = trailer;
            CarType = carType;  
        }


    }
}
