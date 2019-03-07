using MallOfElectronics.Models.Equal;
using MallOfElectronics.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MallOfElectronics.Models.DataBase;

namespace MallOfElectronics.Controllers.Buy
{
    public class BuyController : Controller
    {
        public ActionResult ListOfBuying()
        {
            BuyRepository buyRepository = new BuyRepository();
            List<MallOfElectronics.Models.DataBase.Buy> listOfBuying = new List<Models.DataBase.Buy>();
            listOfBuying = buyRepository.select().ToList();
            return View(listOfBuying);
        }

        [HttpGet]
        public ActionResult DeletingBuying(long trackingCode)
        {
            BuyRepository buyRepository = new BuyRepository();
            MallOfElectronics.Models.DataBase.Buy buy = new Models.DataBase.Buy();
            buy = buyRepository.Find(trackingCode);
            return View(buy);
        }

        [HttpPost]
        public ActionResult DeletingBuying(MallOfElectronics.Models.DataBase.Buy buy)
        {
            BuyRepository buyRepository = new BuyRepository();
            if (buyRepository.Delete(buy.TrackingCode))
                ViewBag.Message = "Buying Has Been Delete";
            else
                ViewBag.ErrorMessage = "Buying Not Has Been Delete";
            return View(buy);
        }

    }
}
