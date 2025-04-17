using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Requesting_Information.Car_Details;

namespace CarTransportationService.Data.Car_Details
{
    internal class Car
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public VehicleType VehicleType { get; set; }

        public Car() { }
        public Car(int id, int year, string mark, string model, VehicleType vehicleType)
        {
            Id = id;
            Year = year;
            Mark = mark;
            Model = model;
            VehicleType = vehicleType;
        }
    }

}
