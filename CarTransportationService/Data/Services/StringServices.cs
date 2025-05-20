using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Requesting_Information.Car_Details;

namespace CarTransportationService.Data.Services
{
    public static class StringServices
    {
        public static VehicleType ConvertToVehicleType(this string item)
        {
            if (item.ToLower() == "motorcycle")
            {
                return VehicleType.motorcycle;
            }
            else if (item.ToLower() == "sedan")
            {
                return VehicleType.sedan;
            }
            else if (item.ToLower() == "jeep")
            {
                return VehicleType.jeep;
            }
            return VehicleType.other;
        }
    }
}
