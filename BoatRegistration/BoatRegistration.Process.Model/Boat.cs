namespace BoatRegistration.Process.Model
{
    public class Boat
    {
        public int ID { get; set; }

        public bool IsBooked { get; set; }

        public int HourlyCharges { get; set; }

        public string BoatName { get; set; }

        public string CustomerName { get; set; }
    }
}
