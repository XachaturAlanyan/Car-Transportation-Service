using CarTransportationService.Abstraction.Interfaces;
using CarTransportationService.Request;
using CarTransportationService.Requesting_Information.Car_Details;
using CarTransportationService.Requesting_Information.Destination;
using CarTransportationService.Requesting_Information.Trailer_Details;

namespace CarTransportationService.Data
{
	interface ICalculationService
	{
		float Calculate(CalculationModel calculationModel);
	}

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

	interface IDatabaseService
	{
		CalculationModel ConstructCalculationModel(string from, string to, Trailer trailer, bool isOperable, Car car);
	}

	class DatabaseService : IDatabaseService
	{
		private readonly IRepository<CarType> _carTypeRepository;
		private readonly IRepository<CarOperable> _carOperableRepository;
		private readonly IRepository<Route> _carRouteRepository;
		private readonly IRepository<TrailerType> _carTrailerRepository;

		public DatabaseService(
			IRepository<CarType> carTypeRepository,
			IRepository<CarOperable> carOperableRepository,
			IRepository<Route> carRouteRepository,
			IRepository<TrailerType> carTrailerRepository
			)
		{
			_carTypeRepository = carTypeRepository;
			_carOperableRepository = carOperableRepository;
			_carRouteRepository = carRouteRepository;
			_carTrailerRepository = carTrailerRepository;
		}

		public CalculationModel ConstructCalculationModel(string from, string to, Trailer trailer, bool isOperable, Car car)
		{
			var carType = _carTypeRepository.GetItem(x => x.VehicleType == VehicleType.sedan);
			var carOperable = _carOperableRepository.GetItem(x => x.IsOperable == isOperable);
			var carRoute = _carRouteRepository.GetItem(x => x.From == from && x.To == to);
			var carTrailer = _carTrailerRepository.GetItem(x => x.Trailer == trailer);

			return new CalculationModel(0, carOperable, carTrailer, carRoute, carType);
		}
	}
}
