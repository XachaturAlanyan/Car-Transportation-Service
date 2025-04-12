using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTransportationService.Requesting_Information.Car_Details
{
    internal class CarType 
    {
        public static int Id { get; set; } = 1;
        public VehicleType VehicleType {  get; set; }
        public float Coefficient { get; set; }

        public CarType(VehicleType vehicleType, float coefficient)
        {
            VehicleType = vehicleType;
            Coefficient = coefficient;
            Id++;
        }

        public CarType()
        {
        }
    }

    enum VehicleType 
    {
        motorcycle,
        sedan,
        jeep,
        other
    }
}
