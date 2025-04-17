using CarTransportationService.Abstraction.Interfaces;
using CarTransportationService.Request;
using CarTransportationService.Requesting_Information.Car_Details;
using CarTransportationService.Requesting_Information.Destination;
using CarTransportationService.Requesting_Information.Trailer_Details;

namespace CarTransportationService.Data
{
	internal class CalculationService : ICalculationService
	{
		private readonly IDatabaseService _databaseService;

		public CalculationService(IDatabaseService databaseService)
		{
			_databaseService = databaseService;
		}

		public float Calculate(CalculationModel calculationModel)
		{
			return
				calculationModel.CarType.Coefficient
				* calculationModel.CarOperable.Coefficient
				* calculationModel.TrailerType.Coefficient
				* calculationModel.Route.Price;
        }
	}
	

}
