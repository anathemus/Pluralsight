using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [HttpPost]
        public ActionResult Search(string name = "Index")
        {
            var message = Server.HtmlEncode(name);

            // var name = RouteData.Values["name"];
            return Content(message);
            // return RedirectToAction("Index", "Home", new { name = name });
            // return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            // return File(Server.MapPath("../Content/site.css"), "text/css");
            // return Json(new {Message = message, Name = "Benjamin" }, JsonRequestBehavior.AllowGet);
        }
    }
}