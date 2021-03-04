using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MISA.JetPayWebsite.Models;

namespace MISA.JetPayWebsite.Controllers
{
    /// <summary>
    /// Controller to support integrate payment (support, register)
    /// </summary>
    /// Created by: NVThanh (08/03/2019)
    public class JetPayPaymentIntegrateController : Controller
    {
        /// <summary>
        /// Support integrate payment
        /// </summary>
        /// <returns></returns>
        /// Created by: NVThanh (08/03/2019)
        public ActionResult Overview()
        {
            return View();
        }

        public async Task<ActionResult> RegisterIntegrateInfo(RegisterIntegrateInfo registerIntegrateInfo)
        {
            //TODO: Gọi đến API đăng ký tích hợp thanh toán
            return View("Overview");
        }
    }
}