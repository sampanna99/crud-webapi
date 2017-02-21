using CRUDWebAPI_Client.Models;
using System.Web.Mvc;

namespace CRUDWebAPI_Client.Controllers
{
    public class ProductController : Controller
    {


        public ActionResult Index()
        {
            ProductClient pc = new ProductClient();
            ViewBag.listProducts = pc.findAll();
            return View();
        }
    }
}