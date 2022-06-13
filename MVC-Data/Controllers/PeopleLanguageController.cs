using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Data.Data;
using MVC_Data.Models;
using System.Linq;

namespace MVC_Data.Controllers
{
    public class PeopleLanguageController : Controller
    {
        private readonly ApplicationDbContent _context;

        public PeopleLanguageController(ApplicationDbContent context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddPersonToLanguage()
        {
            ViewBag.People    = new SelectList(_context.People, "Name", "Name");
            ViewBag.Languages = new SelectList(_context.Langs, "Name", "Name");
            //Display 
            return View();
        }

        [HttpPost]
        public IActionResult AddPersonToLanguage(string personName, string languageName)
        {
            PersonLanguage model = new PersonLanguage();
            model.PersonName = personName;
            model.LanguageName = languageName;
            _context.PersonLanguages.Add(model);
            _context.SaveChanges();
            return View();

        }
    }
}
