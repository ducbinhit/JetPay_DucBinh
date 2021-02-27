using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MISA.JETPAY.DemoPaymentGateway.Common;
using Newtonsoft.Json;
using MISA.JETPAY.DemoPaymentDateway.Models;

namespace MISA.JETPAY.DemoPaymentDateway.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult gateway()
        {
            // Call api token 
            // call api=> datakey and napaskey

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        /// <summary>
        /// Nhận kết quả trả về từ napas
        /// </summary>
        /// <param name="napasResult"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NapasResult([FromForm]string napasResult)
        {
            var objRes= JsonConvert.DeserializeObject<NapasResult>(napasResult);
            var data = CommonFunction.Base64Decode(objRes.data);

            return View();
        }
    }
}
