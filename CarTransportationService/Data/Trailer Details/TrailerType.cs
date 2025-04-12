using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTransportationService.Requesting_Information.Trailer_Details
{
    internal class TrailerType
    {
        public static int Id { get; set; } = 1;
        public Trailer Trailer { get; set; }
        public float Coefficient { get; set; }

        public TrailerType(Trailer trailer, float coefficient)
        {
            Trailer = trailer;
            Coefficient = coefficient;
            Id++;
        }

        public TrailerType()
        {
        }
    }

    enum Trailer 
    {
        Open,
        Enclosed
    }
}
