using BoatRegistration.Data.Model;
using System.Linq;

namespace BoatRegistration.Data
{
    public interface IBoatData
    {
        int AddBoat(string boatname, int hourlyCharges);
        Boat FindBoat(int boatNumber);
        void UpdateBoat(Boat boat, string customerName);
    }
}
