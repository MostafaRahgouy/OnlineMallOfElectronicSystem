using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MallOfElectronics.Models.DataBase;
using MallOfElectronics.Models.Repository;
using MallOfElectronics.Models.Equal;

namespace MallOfElectronics.Controllers.Company
{
    public class CompanyController : Controller
    {
        [HttpPost]
        public ActionResult DeletingCompany(MallOfElectronics.Models.DataBase.Company company)
        {
            CompanyRepository companyRepository = new CompanyRepository();
            if (companyRepository.delete(company.Id))
                ViewBag.message = "This Company Has Been Deleted";
            else
                ViewBag.ErrorMessage = "This Company Not Has Been Deleted";
            return View();
        }
        [HttpGet]
        public ActionResult DeletingCompany(long id)
        {
            CompanyRepository companyRepository = new CompanyRepository();
            MallOfElectronics.Models.DataBase.Company company = new Models.DataBase.Company();
            company = companyRepository.Find(id);
            return View(company);
        }
        public ActionResult ListOfCompanies()
        {
            CompanyRepository companyRepository = new CompanyRepository();
            List<MallOfElectronics.Models.DataBase.Company> listOfCompanies = new List<Models.DataBase.Company>();
            listOfCompanies = companyRepository.select().ToList();
            return View(listOfCompanies);
        }
        [HttpGet]
        public ActionResult AddingCompany()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddingCompany(MallOfElectronics.Models.DataBase.Company company)
        {
            if (ModelState.IsValid)
            {
                CompanyRepository companyRepository = new CompanyRepository();
                if (companyRepository.Add(company))
                    ViewBag.Message = "This Company Has Been Added";
                else
                    ViewBag.ErrorMessage = "This Company Not Has Been Added";
            }
            else
                ViewBag.ErrorMessage = "This Company Not Has Been Added";
            return View();
        }
        public ActionResult EditingCompany(long id)
        {
            MallOfElectronics.Models.DataBase.Company company = new Models.DataBase.Company();
            CompanyRepository companyRepository = new CompanyRepository();
            company = companyRepository.Find(id);
            TempData["prviousCompany"] = company;
            return View(company);
        }
        [HttpPost]
        public ActionResult EditingCompany(MallOfElectronics.Models.DataBase.Company company)
        {
            MallOfElectronics.Models.DataBase.Company previousCompany =
                            (MallOfElectronics.Models.DataBase.Company)TempData["prviousCompany"];
            CompanyRepository companyRepository = new CompanyRepository();
            CheckEqualForCompanies check = new CheckEqualForCompanies();
            if (!check.IsEqual(previousCompany, company))
            {
                if (companyRepository.update(company))
                    ViewBag.message = "This Company Has Been Updated";
                else
                    ViewBag.ErrorMessage = "Not Item Of Company For Change";
            }
            else
                ViewBag.ErrorMessage = "This Company Not Has Been Updated";
            return View();
        }
    }
}
