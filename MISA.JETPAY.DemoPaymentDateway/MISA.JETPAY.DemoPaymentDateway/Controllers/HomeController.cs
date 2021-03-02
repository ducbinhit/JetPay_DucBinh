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
            var result = new GetTokenResData();
            return View(result);
        }
        [HttpPost]
        public IActionResult gateway(GetTokenResData dl)
        {
            string orderId = dl.order.id;
            string amount = dl.order.amount;
            string[] arrListStr = amount.Split(' ');
            amount = arrListStr[0];
            return GetTokenNapas(orderId, amount);
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
            else if(data.result == "ERROR")
            {
                data.id = myJObject.SelectToken("$.paymentResult.order.id").Value<string>();
            }
            // Lưu dữ liệu lên database
            DataController dataController = new DataController();
            dataController.Post(data);
            return View(data);
        }

        /// <summary>
        /// API lấy token từ bên napas
        /// </summary>
        /// <returns></returns>
        public  IActionResult GetTokenNapas(string orderId, string amount)
        {
            try
            {
                // Lấy access_token
                var url = "https://dps-staging.napas.com.vn/api/oauth/token";
                var objReq = new GetTokenReq
                {
                    grant_type = "password",
                    client_id = "APITEST",
                    client_secret = "TT3F6AM5UQZXJEJXAWJ8CHVC9ZJ02A51",
                    username = "apitest",
                    password = "fPJFVp5qnCWeFmtd"
                };
                var result =  CommonFunction.CallAPIService<GetTokenRes>(url, "post", "application/x-www-form-urlencoded", CommonFunction.GetQueryString(objReq), null);

                // Lấy dataKey và napasKey
                var inputParameterReq = new InputParameters
                {
                    clientIP = "192.168.1.1",
                    deviceId = "0123456789",
                    environment = "WebApp",
                    cardScheme = "AtmCard",
                    enable3DSecure = "false"
                };
                var orderReq = new Order
                {
                    id = orderId,
                    amount = amount,
                    currency = "VND"
                };
                var objReqKey = new GetTokenKey
                {
                    apiOperation = "DATA_KEY",
                    inputParameters = inputParameterReq,
                    order = orderReq
                };
                Dictionary<string, string> header = new Dictionary<string, string>();
                header.Add("Authorization", "Bearer "+ result.access_token);
                var accessToken = result.access_token;
                var objReqString = JsonConvert.SerializeObject(objReqKey);
                var url1 = $"https://dps-staging.napas.com.vn/api/rest/version/32/merchant/APITEST/datakey?access_token={accessToken}";
                //var url1 = "https://dps-staging.napas.com.vn/api/rest/version/32/merchant/APITEST/datakey";
                //var resultKey = CommonFunction.CallAPIService<GetTokenResData>(url1, "post", "application/json", objReqString, header);
                var resultKey =  CommonFunction.CallAPIService<GetTokenResData>(url1, "post", "application/json", objReqString, null);

                //Đọc json từ file txt
                //var obj = System.IO.File.ReadAllText("C:/Users/ndbinh/source/repos/JetPay_DucBinh/MISA.JETPAY.DemoPaymentDateway/MISA.JETPAY.DemoPaymentDateway/ObjReqKey.txt");
                //return View(resultKey);
                return View("gateway", resultKey);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
