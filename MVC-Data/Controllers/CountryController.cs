using Microsoft.AspNetCore.Mvc;
using MVC_Data.Data;
using MVC_Data.Models;
using System.Linq;

namespace MVC_Data.Controllers
{
    public class CountryController : Controller
    {
        private readonly ApplicationDbContent _context;

        public CountryController(ApplicationDbContent context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Countries()
        {
            var listOfCountries = _context.Countries.ToList();
            return View(listOfCountries);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Countries.Add(country);
                _context.SaveChanges();
                return RedirectToAction("Countries");

            }
            return View();
        }

        public IActionResult Remove(string name)
        {
            var countryToRemove = _context.Countries.Find(name);

            _context.Countries.Remove(countryToRemove);
            _context.SaveChanges();

            return RedirectToAction("Countries");
        }


    }
}
