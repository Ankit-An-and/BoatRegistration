using BoatRegistration.Data.Model;
using System.Linq;

namespace BoatRegistration.Data
{
    public class BoatData : IBoatData
    {
        private readonly BaseContext _context;
        public BoatData(BaseContext context)
        {
            _context = context;
        }

        public Boat FindBoat(int boatNumber)
        {
            return _context.Boats.SingleOrDefault(x => x.ID == boatNumber);
        }

        public int AddBoat(string boatname, int hourlyCharges)
        {
            var boat = new Boat
            {
                BoatName = boatname,
                HourlyCharges = hourlyCharges,
            };
            _context.Add(boat);
            _context.SaveChanges();

            return boat.ID;
        }

        public void UpdateBoat(Boat boat, string customerName)
        {
            boat.CustomerName = customerName;
            boat.IsBooked = true;
            _context.SaveChanges();
        }
    }
}
