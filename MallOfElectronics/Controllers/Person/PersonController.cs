using MallOfElectronics.Models.DataBase;
using MallOfElectronics.Models.Equal;
using MallOfElectronics.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MallOfElectronics.Controllers.person
{
    public class PersonController : Controller
    {
        public ActionResult EditingUser(long id)
        {
            MallOfElectronics.Models.DataBase.Person person = new Models.DataBase.Person();
            PersonRepository personRepository = new PersonRepository();
            person = personRepository.Find(id);
            TempData["prviousProduct"] = person;
            return View(person);
        }
        [HttpPost]
        public ActionResult EditingUser(MallOfElectronics.Models.DataBase.Person person)
        {
            MallOfElectronics.Models.DataBase.Person previousPerson =
                                        (MallOfElectronics.Models.DataBase.Person)TempData["prviousProduct"];
            PersonRepository personRepository = new PersonRepository();
            CheckEqualForUsers check = new CheckEqualForUsers();
            if (!check.IsEqual(previousPerson , person))
            {
                if (personRepository.update(person))
                    ViewBag.message = "This User Has Been Updated";
                else
                    ViewBag.ErrorMessage = "Not Item Of Users To Change";
            }
            else
                ViewBag.ErrorMessage = "This User Has Been Updated";
            return View();
        }
        [HttpPost]
        public ActionResult DeletingUser(MallOfElectronics.Models.DataBase.Person person)
        {
            MallOfElectronics.Models.Repository.PersonRepository db = new Models.Repository.PersonRepository();
            if (db.Delete(person.Id))
                ViewBag.message = "This User Has Been Deleted";
            else
                ViewBag.ErrorMessage = "This User Not Hass Been Delete";
            return View(person);
        }
        [HttpGet]
        public ActionResult DeletingUser(long id)
        {
            MallOfElectronics.Models.Repository.PersonRepository db = new Models.Repository.PersonRepository();
            Person person = new Person();
            person = db.Find(id);
            return View(person);
        }
        public ActionResult ListOfUsers()
        {
            List<Person> listOfUsers = new List<Person>();
            PersonRepository userRepository = new PersonRepository();
            listOfUsers = userRepository.select().ToList();
            return View(listOfUsers);
        }
    }
}
