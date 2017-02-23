using CRUDWebApi_Client1.Models;
using CRUDWebApi_Client1.ViewModels;
using System;
using System.Web.Mvc;

namespace CRUDWebApi_Client1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            ProductClient pc = new ProductClient();
            ViewBag.listProducts = pc.findAll();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel pvm)
        {
            pvm.product.CreationDate = DateTime.Now;
            ProductClient pc = new ProductClient();
            pc.Create(pvm.product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            ProductClient pc = new ProductClient();
            pc.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            ProductClient pc = new ProductClient();
            ProductViewModel pvm = new ProductViewModel();
            // pvm.product = pc.find(id);
            return View("Index", pvm);
        }
    }
}