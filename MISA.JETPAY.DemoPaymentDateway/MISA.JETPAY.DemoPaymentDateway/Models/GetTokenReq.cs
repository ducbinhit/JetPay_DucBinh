using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.JETPAY.DemoPaymentGateway.Models
{
    /// <summary>
    /// Thông tin gửi lên server để lấy access_token
    /// </summary>
    public class GetTokenReq
    {
        public string grant_type { get; set; }
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }


    /// <summary>
    /// Thông tin trả về từ server khi lấy access_token thành công
    /// </summary>
    public class GetTokenRes
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string refresh_token { get; set; }
        public int expires_in { get; set; }
        public string scope { get; set; }
    }

    /// <summary>
    /// Thông tin gửi lên server khi lấy datakey và napaskey
    /// </summary>
    public class GetTokenKey
    {
        public string apiOperation { get; set; }
        public InputParameters inputParameters { get; set; }
        public Order order { get; set; }

    }

    /// <summary>
    /// Thông tin khách hàng và thẻ
    /// </summary>
    public class InputParameters
    {
        public string clientIP { get; set; }
        public string deviceId { get; set; }
        public string environment { get; set; }
        public string cardScheme { get; set; }
        public string enable3DSecure { get; set; }
    }

    /// <summary>
    /// Thông tin đơn hàng
    /// </summary>
    public class Order
    {
        public string id { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
    }

    /// <summary>
    /// Thông tin khi lấy dataKey, napasKey thành công
    /// </summary>
    public class GetTokenResData
    {
        public string apiOperation { get; set; }
        public Order order { get; set; }
        public string result { get; set; }
        public string dataKey { get; set; }
        public string napasKey { get; set; }
    }

    /// <summary>
    /// Thông tin khi lấy dataKey, napasKey lỗi
    /// </summary>
    public class GetTokenErr
    {
        public string error { get; set; }
        public string error_description { get; set; }
    }
}
