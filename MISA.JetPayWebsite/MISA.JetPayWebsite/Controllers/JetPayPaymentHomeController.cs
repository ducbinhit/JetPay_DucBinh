using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISA.JetPayWebsite.Controllers
{
    public class JetPayPaymentHomeController : Controller
    {
        // GET: JetPayPaymentHome
        public ActionResult Index()
        {
            return View($"Index");
        }
    }
}