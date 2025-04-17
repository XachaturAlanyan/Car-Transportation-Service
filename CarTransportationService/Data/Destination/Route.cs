namespace CarTransportationService.Requesting_Information.Destination
{
	internal class Route
    {
        public string From { get; set; }
        public string To { get; set; }
        public float Price { get; set; }
        public int Distance {  get; set; }

        public Route(string from, string to, float price)
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
