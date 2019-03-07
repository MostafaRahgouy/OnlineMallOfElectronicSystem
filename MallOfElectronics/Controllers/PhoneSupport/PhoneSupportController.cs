using MallOfElectronics.Models.Equal;
using MallOfElectronics.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MallOfElectronics.Controllers.PhoneSupport
{
    public class PhoneSupportController : Controller
    {
        [HttpGet]
        public ActionResult AddingPhoneSupport()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddingPhoneSupport(MallOfElectronics.Models.DataBase.PhoneSupport phoneSupport)
        {
            if (ModelState.IsValid)
            {
                PhoneSupportRepository phoneSupportRepository = new PhoneSupportRepository();
                if (phoneSupportRepository.Add(phoneSupport))
                    ViewBag.Message = "This Phone Has Been Added";
                else
                    ViewBag.ErrorMessage = "This Phone Not Has Been Added";
            }
            else
                ViewBag.ErroMessage = "This Phone Not Has Been Addd";
            return View();
        }
        public ActionResult ListOfPhoneSupport()
        {
            PhoneSupportRepository phoneSupportRepository = new PhoneSupportRepository();
            List<MallOfElectronics.Models.DataBase.PhoneSupport> listOfPhoneSupport =
                                     new List<Models.DataBase.PhoneSupport>();
            listOfPhoneSupport = phoneSupportRepository.select().ToList();
            return View(listOfPhoneSupport);
        }
        [HttpGet]
        public ActionResult DeletingPhoneSupport(long id)
        {
            PhoneSupportRepository phoneSupportRepository = new PhoneSupportRepository();
            MallOfElectronics.Models.DataBase.PhoneSupport phoneSupport = new Models.DataBase.PhoneSupport();
            phoneSupport = phoneSupportRepository.Find(id);
            return View(phoneSupport);
        }
        [HttpPost]
        public ActionResult DeletingPhoneSupport(MallOfElectronics.Models.DataBase.PhoneSupport phoneSupport)
        {
            PhoneSupportRepository phoneSupportRepository = new PhoneSupportRepository();
            if (phoneSupportRepository.Delete(phoneSupport.id))
                ViewBag.Message = "This Phone Support Has Been Delete";
            else
                ViewBag.ErrorMessage = "This Phone Support Not Has Been Delete";
            return View();
        }
        public ActionResult EditingPhoneSupport(long id)
        {
            MallOfElectronics.Models.DataBase.PhoneSupport phoneSupport = new Models.DataBase.PhoneSupport();
            PhoneSupportRepository PhoneSupportRepository = new PhoneSupportRepository();
            phoneSupport = PhoneSupportRepository.Find(id);
            TempData["prviousPhoneSupport"] = phoneSupport;
            return View(phoneSupport);
        }
        [HttpPost]
        public ActionResult EditingPhoneSupport(MallOfElectronics.Models.DataBase.PhoneSupport phoneSupport)
        {
            MallOfElectronics.Models.DataBase.PhoneSupport previousPhoneSupport =
                (MallOfElectronics.Models.DataBase.PhoneSupport)TempData["prviousPhoneSupport"];
            PhoneSupportRepository phoneSupportRepository = new PhoneSupportRepository();
            CheckEqualForPhoneSupport check = new CheckEqualForPhoneSupport();
            if (!check.IsEqual(previousPhoneSupport, phoneSupport))
            {
                if (phoneSupportRepository.update(phoneSupport))
                    ViewBag.message = "The Phone Support Has Been Updated";
                else
                    ViewBag.ErrorMessage = "Not Item Of Phone Support To Change";
            }
            else
                ViewBag.ErrorMessage = "The Phone Support Has Not Been Updated";
            return View();
        }
    }
}
