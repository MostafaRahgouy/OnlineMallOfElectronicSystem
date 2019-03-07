using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MallOfElectronics.Models.Repository;
using MallOfElectronics.Models.DataBase;
using MallOfElectronics.Models.Equal;

namespace MallOfElectronics.Controllers.Product
{
    public class ProductController : Controller
    {
        public ActionResult DisplayProductDetails(int productId)
        {
            ProductsRepository productsrepository = new ProductsRepository();
            MallOfElectronics.Models.DataBase.Product product = new Models.DataBase.Product();
            product = productsrepository.Find(productId);
            CompanyRepository companyRepository = new CompanyRepository();
            ViewBag.companyName = (companyRepository.Find(product.CompanyId)).Name;
            return View(product);
        }
        public ActionResult Product(int productType , string titleLink )
        {
            ViewBag.productType = productType;
            ViewBag.titleLink = titleLink;
            return View();
        }

        [HttpGet]
        public ActionResult DeletingProduct(long id)
        {
            ProductsRepository productRepository = new ProductsRepository();
            MallOfElectronics.Models.DataBase.Product product = new Models.DataBase.Product();
            product = productRepository.Find(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult DeletingProduct(MallOfElectronics.Models.DataBase.Product product)
        {
            ProductsRepository productRepository = new ProductsRepository();
            if (productRepository.Delete(product.Id))
                ViewBag.message = "This Product Has Been Deleted";
            else
                ViewBag.ErrorMessage = "This Product Not Has Been Deleted";
            return View();
        }

        [HttpGet]
        public ActionResult EditingProduct(long id)
        {
            MallOfElectronics.Models.DataBase.Product product = new Models.DataBase.Product();
            ProductsRepository productRepository = new ProductsRepository();
            product = productRepository.Find(id);
            TempData["prviousProduct"] = product;
            return View(product);
        }
        [HttpPost]
        public ActionResult EditingProduct(MallOfElectronics.Models.DataBase.Product product)
        {
            MallOfElectronics.Models.DataBase.Product previousProduct =
                                        (MallOfElectronics.Models.DataBase.Product)TempData["prviousProduct"];
            ProductsRepository productRepository = new ProductsRepository();
            CheckEqualForProducts check = new CheckEqualForProducts();
            if (!check.IsEqual(previousProduct , product))
            {
                if (productRepository.update(product))
                    ViewBag.message = "This Product Has Been Updated";
                else
                    ViewBag.ErrorMessage = "Not Item Of Product To Change";
            }
            else
                ViewBag.ErrorMessage = "This Product Not Has Been Updated";
            return View();
        }


        [HttpGet]
        public ActionResult AddingProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddingProduct(MallOfElectronics.Models.DataBase.Product product, HttpPostedFileBase UploadImage)
        {
            if (ModelState.IsValid)
            {
                string physicalPath = "", ImageName = "Images/ProductsImages/";
                if (UploadImage != null)
                {
                    physicalPath = Server.MapPath("~") + "Images\\ProductsImages\\" + UploadImage.FileName;
                    UploadImage.SaveAs(physicalPath);
                    ImageName += UploadImage.FileName;
                }
                else
                {
                    ImageName += "EmptyProductsImage.jpg";
                }
                product.Image = ImageName;

                ProductsRepository productRepository = new ProductsRepository();
                if (productRepository.Add(product))
                    ViewBag.Message = "This Product Has Been Added";
                else
                {
                    if (UploadImage != null)
                    {
                        System.IO.File.Delete(physicalPath);
                    }
                    ViewBag.ErrorMessage = "This Product Not Has Been Added";
                }
            }
            else
                ViewBag.ErrorMessage = "This Product Not Has Been Added";
            return View();
        }
        public ActionResult ListOfProducts()
        {
            ProductsRepository productRepository = new ProductsRepository(); 
            List<MallOfElectronics.Models.DataBase.Product> listOfProducts = new List<Models.DataBase.Product>();
            listOfProducts = productRepository.select().ToList();
            return View(listOfProducts);
        }
    }
}
