using Microsoft.AspNetCore.Mvc;
using MVC_Data.Data;
using MVC_Data.Models;
using System.Linq;

namespace MVC_Data.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContent _context;

        public PeopleController(ApplicationDbContent context)
        {
            _context = context;
        }
         
        public IActionResult Index()
        {
            var listOfCars = _context.People.ToList();
            return View(listOfCars);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges(); //actually saves info in database
                return RedirectToAction("Index");
            }
            return View();    
        }

        public IActionResult Remove(string name)
        {
            var peopleToRemove = _context.People.Find(name);

            _context.People.Remove(peopleToRemove);
            _context.SaveChanges();

            return RedirectToAction("Index"); 
        }




    }
}
