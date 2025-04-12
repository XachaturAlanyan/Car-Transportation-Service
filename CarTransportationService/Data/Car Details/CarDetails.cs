using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTransportationService.Requesting_Information.Car_Details
{
    internal class CarDetails
    {
        public static int Id { get;set; } = 1; 
        public string Mark { get; set; }
        public int Year { get; set; }

        public CarDetails(string mark,int year)
        { 
            Mark = mark;
            Year = year;
            Id++;
        }

        public CarDetails()
        {
        }
    }
}
