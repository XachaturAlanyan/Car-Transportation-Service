using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Abstraction.Implementation;
using CarTransportationService.Requesting_Information.Car_Details;

namespace CarTransportationService.Requesting_Information.Destination
{
    internal class Route
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Price { get; set; }

        public int Distance {  get; set; }

        public Route(string from, string to, double price)
        {
            From = from;
            To = to;
            Price = price;
        }

        public Route()
        {
        }

        public int GetDistance(string from, string to) 
        {
            // Implementing some funtion to get the mileage from point a to point b 
            return Distance;
        }

    }
}
