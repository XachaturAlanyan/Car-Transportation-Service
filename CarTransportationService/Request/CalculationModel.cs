using System.Collections.Generic;
using CarTransportationService.Requesting_Information.Car_Details;
using CarTransportationService.Requesting_Information.Destination;
using CarTransportationService.Requesting_Information.Trailer_Details;

namespace CarTransportationService.Request
{
	internal class CalculationModel
	{
		public CarType CarType { get; set; }
		public CarOperable CarOperable { get; set; }
		public TrailerType TrailerType { get; set; }
		public Route Route { get; set; }

		public CalculationModel(CarOperable carOperable, TrailerType trailerType, Route route, CarType carType)
		{
			CarOperable = carOperable;
			TrailerType = trailerType;
			Route = route;
			CarType = carType;
		}
	}
}
