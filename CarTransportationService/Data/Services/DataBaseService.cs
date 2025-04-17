using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Abstraction.Implementation;
using CarTransportationService.Abstraction.Interfaces;
using CarTransportationService.Data.Car_Details;
using CarTransportationService.Request;
using CarTransportationService.Requesting_Information.Car_Details;
using CarTransportationService.Requesting_Information.Destination;
using CarTransportationService.Requesting_Information.Trailer_Details;

namespace CarTransportationService.Data.Services
{
    internal class DatabaseService : IDatabaseService
    {
        private readonly Repository<CarType> _carTypeRepository;
        private readonly Repository<CarOperable> _carOperableRepository;
        private readonly Repository<Route> _RouteRepository;
        private readonly Repository<TrailerType> _TrailerRepository;
        private readonly Repository<Car> _CarRepository;

        public DatabaseService(
            Repository<Car> CarRepository,
            Repository<CarType> carTypeRepository,
            Repository<CarOperable> carOperableRepository,
            Repository<Route> RouteRepository,
            Repository<TrailerType> TrailerRepository
            )
        {
            _CarRepository = CarRepository;
            _carTypeRepository = carTypeRepository;
            _carOperableRepository = carOperableRepository;
            _RouteRepository = RouteRepository;
            _TrailerRepository = TrailerRepository;
        }

        public CalculationModel ConstructCalculationModel(UserRequest userReqeust)
        {
            var car = _CarRepository.GetItem(x=> x.Mark ==  userReqeust.Mark && x.Model == userReqeust.Model && x.Year == userReqeust.Year);
            var carType = _carTypeRepository.GetItem(x => x.VehicleType == car.VehicleType);
            var carOperable = _carOperableRepository.GetItem(x => x.IsOperable == userReqeust.IsOperable);
            var carRoute = _RouteRepository.GetItem(x => x.From == userReqeust.From && x.To == userReqeust.To);
            var carTrailer = _TrailerRepository.GetItem(x => x.Trailer == userReqeust.Trailer);

            return new CalculationModel(carOperable, carTrailer, carRoute, carType);
        }

        public void InitializeDataBase() 
        {
            _carTypeRepository.Add(new CarType(1, VehicleType.motorcycle, 1.1f));
            _carTypeRepository.Add(new CarType(2, VehicleType.sedan, 1.2f));
            _carTypeRepository.Add(new CarType(3, VehicleType.jeep, 1.3f));
            _carTypeRepository.Add(new CarType(4, VehicleType.other, 1.5f));
            _CarRepository.Add(new Car(1, 2023, "BMW", "X1", VehicleType.jeep));
            _CarRepository.Add(new Car(2, 2022, "Toyota", "Corolla", VehicleType.sedan));
            _CarRepository.Add(new Car(3, 2021, "Ford", "Escape", VehicleType.jeep));
            _CarRepository.Add(new Car(4, 2023, "Honda", "Civic", VehicleType.sedan));
            _CarRepository.Add(new Car(5, 2020, "Harley-Davidson", "Iron 883", VehicleType.motorcycle));
            _CarRepository.Add(new Car(6, 2021, "Ducati", "Monster", VehicleType.motorcycle));
            _CarRepository.Add(new Car(7, 2023, "Chevrolet", "Equinox", VehicleType.jeep));
            _CarRepository.Add(new Car(8, 2022, "Tesla", "Model 3", VehicleType.sedan));
            _CarRepository.Add(new Car(9, 2019, "Yamaha", "MT-07", VehicleType.motorcycle));
            _CarRepository.Add(new Car(10, 2023, "Subaru", "Outback", VehicleType.other));
            _CarRepository.Add(new Car(11, 2021, "Mercedes-Benz", "C-Class", VehicleType.sedan));
            _CarRepository.Add(new Car(12, 2020, "Jeep", "Wrangler", VehicleType.jeep));
            _CarRepository.Add(new Car(13, 2023, "Hyundai", "Elantra", VehicleType.sedan));
            _CarRepository.Add(new Car(14, 2021, "Kawasaki", "Ninja 400", VehicleType.motorcycle));
            _CarRepository.Add(new Car(15, 2022, "Mazda", "CX-5", VehicleType.jeep));
            _CarRepository.Add(new Car(16, 2023, "Volkswagen", "Passat", VehicleType.sedan));
            _CarRepository.Add(new Car(17, 2020, "Suzuki", "GSX-R750", VehicleType.motorcycle));
            _CarRepository.Add(new Car(18, 2023, "Nissan", "Altima", VehicleType.sedan));
            _CarRepository.Add(new Car(19, 2021, "Toyota", "RAV4", VehicleType.jeep));
            _CarRepository.Add(new Car(20, 2022, "Polaris", "Slingshot", VehicleType.other));
            _CarRepository.Add(new Car(21,2023,"BMW","X1",VehicleType.jeep));
            _carOperableRepository.Add(new CarOperable(1, true, 1.0f));
            _carOperableRepository.Add(new CarOperable(1, false, 1.2f));
            _RouteRepository.Add(new Route("Los Angeles CA", "Dallas TX", 1200.00f));
            _RouteRepository.Add(new Route("Phoenix AZ", "Las Vegas NV", 300.00f));
            _RouteRepository.Add(new Route("Detroit MI", "Cleveland OH", 170.20f));
            _RouteRepository.Add(new Route("Portland OR", "Boise ID", 430.60f));
            _RouteRepository.Add(new Route("Charlotte NC", "Nashville TN", 410.75f));
            _RouteRepository.Add(new Route("Kansas City MO", "Omaha NE", 190.30f));
            _RouteRepository.Add(new Route("New York NY", "Chicago IL", 790.50f));
            _RouteRepository.Add(new Route("San Francisco CA", "Seattle WA", 680.25f));
            _RouteRepository.Add(new Route("Miami FL", "Atlanta GA", 660.00f));
            _RouteRepository.Add(new Route("Denver CO", "Houston TX", 1025.75f));
            _RouteRepository.Add(new Route("Boston MA", "Philadelphia PA", 310.40f));
            _TrailerRepository.Add(new TrailerType(Trailer.Open, 1.5f));
            _TrailerRepository.Add(new TrailerType(Trailer.Enclosed, 1.0f));
        }
    }
}

