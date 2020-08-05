using BoatRegistration.Data;
using System;

namespace BoatRegistration.Process
{
    public class BoatProcess : IBoatProcess
    {

        private readonly IBoatData _boatData;

        public BoatProcess(IBoatData boatData)
        {
            _boatData = boatData;
        }

        public int RegisterBoat(string boatname, int hourlyCharges)
        {
            var id = _boatData.AddBoat(boatname, hourlyCharges);
            return id;
        }

        public string RentBoat(int boatNumber, string customerName)
        {
            var boat = _boatData.FindBoat(boatNumber);

            if (boat == null)
            {
                return $"Boat with ID {boatNumber} not found.";
            }
            else if (boat.IsBooked)
            {
                return $"Boat with ID {boatNumber} is already booked.";
            }
            else
            {
                _boatData.UpdateBoat(boat, customerName);
                return "Boat registered successfully.";
            }
        }
    }
}
