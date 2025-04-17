using CarTransportationService.Abstraction.Interfaces;
using CarTransportationService.Request;

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
