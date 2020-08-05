namespace BoatRegistration.Process
{
    interface IBoatProcess
    {
        int RegisterBoat(string boatname, int hourlyCharges);

        string RentBoat(int boatNumber, string customerName);
    }
}
