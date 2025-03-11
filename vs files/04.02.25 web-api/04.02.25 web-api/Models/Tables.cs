namespace _04._02._25_web_api.Models
{
    public class Pass_in_trip
    {
        public int id { get; set; }
        public int trip { get; set; }
        public int passenger { get; set; }
        public string place { get; set; }
    }

    public class Passenger(int Passenger)
    {
        public int id = Passenger;
        public string name { get; set; }
    }

    public class Trip(int TRIP)
    {
        public int id = TRIP;
        public int company { get; set; }
        public string plane { get; set; }
        public string town_from { get; set; }
        public string town_to { get; set; }
        public DateTime time_out { get; set; }
        public DateTime time_in { get; set; }

    }

    public class Company(int COMPANY)
    {
        public int id = COMPANY;
        public string name { get; set; }
    }
}
