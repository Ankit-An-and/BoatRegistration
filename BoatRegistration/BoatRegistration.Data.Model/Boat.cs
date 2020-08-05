using System.ComponentModel.DataAnnotations.Schema;

namespace BoatRegistration.Data.Model
{
    public class Boat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public bool IsBooked { get; set; }

        public int HourlyCharges { get; set; }

        public string BoatName { get; set; }

        public string CustomerName { get; set; }

    }
}
