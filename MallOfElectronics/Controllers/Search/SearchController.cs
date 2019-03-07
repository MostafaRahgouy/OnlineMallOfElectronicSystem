using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MallOfElectronics.Models.DataBase;
using MallOfElectronics.Models.Repository;

namespace MallOfElectronics.Controllers.Search
{
    public class SearchController : Controller
    {

        public ActionResult Search(string searchTopice)
        {
            List<MallOfElectronics.Models.DataBase.Product> listOfProducts = new List<Models.DataBase.Product>();
            listOfProducts = SearchDepenedentElemenet(searchTopice);
            ViewBag.SearchTopice = "Your Products Not Fount!! Try Again.";
            return View(listOfProducts);
        }
        public ActionResult SearchByTopics(bool Mobile, bool Laptop, bool Tablet, bool Camera, bool VideoCamera,
                                           bool Apple, bool Sony, bool Canon,
                                           bool Black, bool Blue, bool Red)
        {
            List<MallOfElectronics.Models.DataBase.Product> listOfProducts = new List<Models.DataBase.Product>();
            ProductsRepository productRepository = new ProductsRepository();
            if (Mobile)
                listOfProducts.AddRange(MobileProduct(Apple, Sony, Black, Blue, Red));
            if (Laptop)
                listOfProducts.AddRange(LabtopProduct(Apple , Sony , Black , Blue , Red));
            if (Tablet)
                listOfProducts.AddRange(TabletProduct(Apple, Sony, Black, Blue, Red));
            if (Camera)
                listOfProducts.AddRange(CameraProduct(Apple, Sony, Black, Blue, Red));
            if (VideoCamera)
                listOfProducts.AddRange(CameraProduct(Apple, Sony, Black, Blue, Red));
            ViewBag.SearchTopice = "Your Products Not Fount!! Try Again.";
            return View("Search", listOfProducts);
        }
        private List<MallOfElectronics.Models.DataBase.Product> MobileProduct(bool Apple , bool Sony ,
                                                                              bool Black , bool Blue , bool Red)
        {
            List<MallOfElectronics.Models.DataBase.Product> listOfProducts = new List<Models.DataBase.Product>();
            ProductsRepository productRepository = new ProductsRepository();
            if(Black)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 1 && id.Color == "black"));
            if(Blue)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 1 && id.Color == "blue"));
            if(Red)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 1 && id.Color == "red"));
            if (!Blue && !Red && !Blue)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 1));
            return listOfProducts;
        }
        private List<MallOfElectronics.Models.DataBase.Product> LabtopProduct(bool Apple , bool Sony ,
                                                                              bool Black , bool Blue , bool Red)
        {
            List<MallOfElectronics.Models.DataBase.Product> listOfProducts = new List<Models.DataBase.Product>();
            ProductsRepository productRepository = new ProductsRepository();
            if (Black)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 2 && id.Color == "black"));
            if (Blue)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 2 && id.Color == "blue"));
            if (Red)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 2 && id.Color == "red"));
            if (!Blue && !Red && !Blue)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 2));

            return listOfProducts;
        }
        private List<MallOfElectronics.Models.DataBase.Product> TabletProduct(bool Apple , bool Sony ,
                                                                              bool Black , bool Blue , bool Red)
        {
            List<MallOfElectronics.Models.DataBase.Product> listOfProducts = new List<Models.DataBase.Product>();
            ProductsRepository productRepository = new ProductsRepository();
            if (Black)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 3 && id.Color == "black"));
            if (Blue)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 3 && id.Color == "blue"));
            if (Red)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 3 && id.Color == "red"));
            if (!Blue && !Red && !Blue)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 3));
            return listOfProducts;
        }
        private List <MallOfElectronics.Models.DataBase.Product> CameraProduct(bool Apple , bool Sony , 
                                                                               bool Black , bool Blue , bool Red)
        {
            List<MallOfElectronics.Models.DataBase.Product> listOfProducts = new List<Models.DataBase.Product>();
            ProductsRepository productRepository = new ProductsRepository();
            if (Black)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 4 && id.Color == "black"));
            if (Blue)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 4 && id.Color == "blue"));
            if (Red)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 4 && id.Color == "red"));
            if (!Blue && !Red && !Blue)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 4));
            return listOfProducts;
        }
        private List <MallOfElectronics.Models.DataBase.Product> VideoCamera(bool Apple , bool Sony , 
                                                                             bool Black , bool Blue , bool Red)
        {
            List<MallOfElectronics.Models.DataBase.Product> listOfProducts = new List<Models.DataBase.Product>();
            ProductsRepository productRepository = new ProductsRepository();
            if (Black)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 5 && id.Color == "black"));
            if (Blue)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 5 && id.Color == "blue"));
            if (Red)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 5 && id.Color == "red"));
            if (!Blue && !Red && !Blue)
                listOfProducts.AddRange(productRepository.where(id => id.ProductType == 5));

            return listOfProducts;
        }
        private List<MallOfElectronics.Models.DataBase.Product> SearchDepenedentElemenet(string searchTopice)
        {
            ProductsRepository productRepository = new ProductsRepository();
            List<MallOfElectronics.Models.DataBase.Product> listOfProduct = new List<Models.DataBase.Product>();
            listOfProduct = productRepository.where(id => id.Name == searchTopice).ToList<MallOfElectronics.Models.DataBase.Product>();
            return listOfProduct;
        }

    }
}