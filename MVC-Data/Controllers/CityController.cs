using Microsoft.AspNetCore.Mvc;
using MVC_Data.Data;
using MVC_Data.Models;
using System.Linq;

namespace MVC_Data.Controllers
{
    public class CityController : Controller
    {
        private readonly ApplicationDbContent _context;

        public CityController(ApplicationDbContent context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cities()
        {
            var listOfCities = _context.Cities.ToList();
            return View(listOfCities);
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(City city)
        {
            if (ModelState.IsValid)
            {
                _context.Cities.Add(city);
                _context.SaveChanges(); 
                return RedirectToAction("Cities");

            }
            return View();
        }

        public IActionResult Remove(string name)
        {
            var cityToRemove = _context.Cities.Find(name);

            _context.Cities.Remove(cityToRemove);
            _context.SaveChanges();

            return RedirectToAction("Cities");
        }

         

    }
}
