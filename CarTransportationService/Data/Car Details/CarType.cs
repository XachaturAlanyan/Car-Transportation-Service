using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarTransportationService.Requesting_Information.Car_Details
{
   
    internal class CarType 
    {
        public int Id { get; set; }
        public VehicleType VehicleType {  get; set; }
        public float Coefficient { get; set; }

        public CarType(int id,VehicleType vehicleType, float coefficient)
        {
            VehicleType = vehicleType;
            Coefficient = coefficient;
            Id = id;
        }

        public CarType()
        {
        }
    }

    public enum VehicleType 
    {
        motorcycle,
        sedan,
        jeep,
        other
    }
}
