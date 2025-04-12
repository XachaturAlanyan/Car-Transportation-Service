using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTransportationService.Requesting_Information.Car_Details
{
    internal class CarOperable
    {
        public static int Id { get; set; } = 1;
        public bool IsOperable { get; set; }
        public float Coefficient { get; set; }

        public CarOperable(bool isSOperable, float coefficient) 
        {
            IsOperable = isSOperable;
            Coefficient = coefficient;
            Id++;
        }

        public CarOperable()
        {
        }
    }
}
