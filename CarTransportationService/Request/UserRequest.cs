using CarTransportationService.Requesting_Information.Trailer_Details;

namespace CarTransportationService.Request
{
	internal class UserRequest
    {
        public string From { get; set; }
        public string To { get; set; }
        public Trailer Trailer { get; set; }
        public bool IsOperable { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public UserRequest()
        {
            
        }

        public UserRequest(string from, string to, Trailer trailer, bool isOperable, string mark, string model, int year)
        {
            From = from;
            To = to;
            Trailer = trailer;
            IsOperable = isOperable;
            Mark = mark;
            Model = model;
            Year = year;
        }
    }
}
