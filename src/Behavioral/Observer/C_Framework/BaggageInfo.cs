namespace DesignPatterns.Behavioral.Observer.C_Framework
{
    public class BaggageInfo
    {
        public BaggageInfo(int flightNumber, string from, int carousel)
        {
            this.FlightNumber = flightNumber;
            this.From = from;
            this.Carousel = carousel;
        }

        public int Carousel { get; set; }
        public int FlightNumber { get; set; }
        public string From { get; set; }
    }
}
