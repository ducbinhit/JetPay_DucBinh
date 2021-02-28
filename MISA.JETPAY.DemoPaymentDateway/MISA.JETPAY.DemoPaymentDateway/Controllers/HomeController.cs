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
using Newtonsoft.Json.Linq;
using MISA.JETPAY.DemoPaymentGateway.Models;
using MISA.JETPAY.DemoPaymentGateway.Api;

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
        public IActionResult NapasResult([FromForm] string napasResult)
        {
            var objRes = JsonConvert.DeserializeObject<NapasResult>(napasResult);
            var dataJson = CommonFunction.Base64Decode(objRes.data);

            // Chuyển data (json) sang dynamic object
            var myJObject = JObject.Parse(dataJson);

            var data = new DataNapas();
            // Trạng thái thanh toán
            data.result = myJObject.SelectToken("$.paymentResult.result").Value<string>();
            if (data.result == "SUCCESS")
            {
                // thành công
                data.merchantId = myJObject.SelectToken("$.paymentResult.merchantId").Value<string>();
                data.amount = myJObject.SelectToken("$.paymentResult.order.amount").Value<string>();
                data.creationTime = myJObject.SelectToken("$.paymentResult.order.creationTime").Value<DateTime>();
                data.currency = myJObject.SelectToken("$.paymentResult.order.currency").Value<string>();
                data.id = myJObject.SelectToken("$.paymentResult.order.id").Value<string>();
                data.nameOnCard = myJObject.SelectToken("$.paymentResult.sourceOfFunds.provided.card.nameOnCard").Value<string>();
                data.issueDate = myJObject.SelectToken("$.paymentResult.sourceOfFunds.provided.card.issueDate").Value<string>();
                data.number = myJObject.SelectToken("$.paymentResult.sourceOfFunds.provided.card.number").Value<string>();
                data.date = myJObject.SelectToken("$.paymentResult.transaction.acquirer.date").Value<DateTime>();
            }
            else if (data.result == "FAILURE")
            {
                data.merchantId = myJObject.SelectToken("$.paymentResult.merchantId").Value<string>();
                data.creationTime = myJObject.SelectToken("$.paymentResult.order.creationTime").Value<DateTime>();
                data.id = myJObject.SelectToken("$.paymentResult.order.id").Value<string>();
            }
            



            DataController dataController = new DataController();
            dataController.Post(data);

            return View();
        }
    }
}
