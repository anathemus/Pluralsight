using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBPersonal_Wesite.Controllers
{
    public class CS50FinanceController : Controller
    {
        // GET: CS50Finance
        [Authorize]
        public ActionResult Index()
        {
           return View();
        }
    }
}