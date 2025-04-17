using CarTransportationService.Abstraction.Implementation;
using CarTransportationService.Data;
using CarTransportationService.Data.Car_Details;
using CarTransportationService.Data.Services;
using CarTransportationService.Request;
using CarTransportationService.Requesting_Information.Car_Details;
using CarTransportationService.Requesting_Information.Destination;
using CarTransportationService.Requesting_Information.Trailer_Details;
using System;

namespace CarTransportationService
{
	internal class Program
    {
        static void Main(string[] args)
        {
            Repository<CarOperable> CarOperableRepository = new Repository<CarOperable>();
            Repository<Car> CarRepository = new Repository<Car>();
            Repository<CarType> CarTypeRepository = new Repository<CarType>();
            Repository<Route> RouteRepository = new Repository<Route>();
            Repository<TrailerType> TrailerRepository = new Repository<TrailerType>();
            DatabaseService DataBase = new DatabaseService(CarRepository, CarTypeRepository, CarOperableRepository, RouteRepository, TrailerRepository);
            DataBase.InitializeDataBase();

            Console.WriteLine("Welcome to our transportation service" +
                "\n Please choose if you are" +
                "\n 1.Admin  2.User  0. Exit");
            while (true)
            {
                ConsoleKey Input = Console.ReadKey().Key;
                switch (Input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("You can Add/Update/Remove/View All of" +
                            "\n 1.Cars" +
                            "\n 2.Routes" +
                            "\n 3.Change Car Operable Coefficient" +
                            "\n 4.Change Trailer Type Coefficient");
                        Input = Console.ReadKey().Key;
                        switch (Input)
                        {
                            case ConsoleKey.D1:
                                break;
                            case ConsoleKey.D2:
                                break;
                            case ConsoleKey.D3:
                                break;
                            case ConsoleKey.D4:
                                break;
                            default:
                                Console.WriteLine("Wrong Input Please try again");
                                break;

                        }
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        Console.WriteLine($"Car Marks are");
                        CarRepository.GetAll().ForEach(x => Console.WriteLine(x.Mark));
                        Console.Write("Please enter Car's Mark: ");
                        string userCarMark = Console.ReadLine();
                        Console.Write("Please enter Car's Model: ");
                        string userCarModel = Console.ReadLine();
                        Console.Write("Please enter Car's Year: ");
                        int userCarYear = int.Parse(Console.ReadLine());
                        Console.Write("Is your Car Operable?: Yes/No: ");
                        bool userCarOperable = Console.ReadLine().ToLower() == "yes" ? true : false;
                        Console.Write("Do you want to transport your car with closed trailer?: ");
                        Trailer userTrailer = Console.ReadLine().ToLower() == "yes" ? Trailer.Enclosed : Trailer.Open;
                        Console.Write("Please enter from where: ");
                        string userFrom = Console.ReadLine();
                        Console.Write("Please enter to where: ");
                        string userTo = Console.ReadLine();
                        UserRequest userRequest = new UserRequest(userFrom,userTo,userTrailer,userCarOperable,userCarMark,userCarModel,userCarYear);
                        CalculationService calculationService = new CalculationService(DataBase);
                        float userPrice = calculationService.Calculate(DataBase.ConstructCalculationModel(userRequest));
                        Console.WriteLine($"Your price is {userPrice}$");
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("Wrong Input Please Choose again:");
                        break;
                }
            }
        }
    }
}
