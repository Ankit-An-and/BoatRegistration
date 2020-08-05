using BoatRegistration.Process;
using Microsoft.AspNetCore.Mvc;

namespace BoatRegistration.Controllers
{
    public class BoatController : Controller
    {
        private readonly BoatProcess _boatProcess;

        public BoatController(BoatProcess boatProcess)
        {
            _boatProcess = boatProcess;
        }

        [HttpGet]
        public IActionResult RegisterBoat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterBoat(string boatName, int hourlyCharges)
        {
            var id = _boatProcess.RegisterBoat(boatName, hourlyCharges);
            ViewBag.Message = $"Boat Registered with ID : {id}";
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public IActionResult RentBoat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RentBoat(int id, string customername)
        {
            var message = _boatProcess.RentBoat(id, customername);
            ViewBag.Message = message;
            ModelState.Clear();
            return View();
        }
    }
}