using CarTransportationService.Requesting_Information.Car_Details;
using CarTransportationService.Requesting_Information.Destination;
using CarTransportationService.Requesting_Information.Trailer_Details;

namespace CarTransportationService.Request
{
	internal class CalculationModel
	{
		public int Id { get; set; }
		//public CarDetails CarDetails { get; set; }
		public CarType CarType { get; set; }
		public CarOperable CarOperable { get; set; }
		public TrailerType TrailerType { get; set; }
		public Route Route { get; set; }

		public CalculationModel(int id, /*CarDetails carDetails,*/ CarOperable carOperable, TrailerType trailerType, Route route, CarType carType)
		{
			Id = id;
			//CarDetails = carDetails;
			CarOperable = carOperable;
			TrailerType = trailerType;
			Route = route;
			CarType = carType;
		}
	}



	class Car
	{
		public int Id { get; set; }
		public string Mark { get; set; }
		public string Model { get; set; }
	}
}
