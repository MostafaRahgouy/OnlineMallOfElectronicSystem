using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using MallOfElectronics.Models.DataBase;
using MallOfElectronics.Models.Repository;

namespace MallOfElectronics.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        // GET: /Account/Login
        Person person = new Models.DataBase.Person();
        PersonRepository personRepository = new Models.Repository.PersonRepository();
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
       // [ValidateAntiForgeryToken]
        public ActionResult Login(Person person, string returnUrl)
        {
            if (checkUserNameAndPassword(person.Email, person.Password))
            {
                FormsAuthentication.SetAuthCookie(person.Name, false);
                Session["username"] = personRepository.Find(person.Email).Name;
                Session["userlevel"] = personRepository.Find(person.Email).IdOfTheCategoryOfPersons.ToString() ;
                return RedirectToLocal(returnUrl);
            }
            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View(person);
        }
        private bool checkUserNameAndPassword(string email, string pasword)
        {
            person = personRepository.Find(email);
            if (person != null)
            {
                if (person.Password == pasword)
                {
                    return true;
                }
            }
            return false;
        }
        // POST: /Account/LogOff
        
    //    [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        // GET: /Account/Register

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
        // POST: /Account/Register

        [HttpPost]
        [AllowAnonymous]
     //   [ValidateAntiForgeryToken]
        public ActionResult Register(Person person, HttpPostedFileBase UploadImage)
        {
            if (personRepository.Find(person.Name) == null)
            {
                string physicalPath = "", ImageName = "Images/PersonsImages/";
                if (UploadImage != null)
                {
                    physicalPath = Server.MapPath("~") + "Images\\PersonsImages\\" + UploadImage.FileName;
                    UploadImage.SaveAs(physicalPath);
                    ImageName += UploadImage.FileName;
                }
                else
                {
                    ImageName += "EmptyPersonImage.jpg";
                }
                person.Image = ImageName;
                person.IdOfTheCategoryOfPersons = 2;
                person.RegisteryDate = DateTime.Now;
                personRepository.Add(person);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "The user name or password provided is all ready exist.");
            }
            return View(person);
        }

        // GET: /Account/Manage
        public ActionResult Manage()
        {
            return View();
        }

        #region Helpers
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        #endregion
    }
}
