using Microsoft.AspNetCore.Mvc;
using MVC_Data.Models;
using System;
using System.Linq;

namespace MVC_Data.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*
        public IActionResult ListOfPeople()
        {
            //Send List of persons to view
            ViewBag.LinkableId = PeopleViewModel.listOfPersons;
            
            //display list of people

            //The table data should come from a view model, which should have a list of people, and
            //the search phrase if one exists.

            return View(PeopleViewModel.listOfPersons);
        }



        [HttpPost]
        public IActionResult ListOfPeople(string searchTerm, string personName, string personCity, int personPhoneNumber, int personId)
        {
      
            //Searchpart 
            if (searchTerm != null)
            {
                foreach (Person person in PeopleViewModel.listOfPersons)
                {

                    if (person.Name.Equals(searchTerm) || person.City.Equals(searchTerm))
                    {
                        PeopleViewModel.listOfPersonsFiltered.Add(person);
                    }
                }
                ViewBag.LinkableId = PeopleViewModel.listOfPersonsFiltered;
                return View();

            }
            //add person
            else if (personName != null && personCity != null && personPhoneNumber != 0 && personId != 0 )
            {
                Person createdPerson = new Person { Name = personName, City = personCity, PhoneNumber = personPhoneNumber, Id = personId };
                PeopleViewModel.listOfPersons.Add(createdPerson);
                ViewBag.LinkableId = PeopleViewModel.listOfPersons;
            }

            //Filter out persons

            return View();
        }*/



    }
}
