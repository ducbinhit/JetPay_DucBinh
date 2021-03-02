using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Web;

namespace MISA.JETPAY.DemoPaymentGateway.Common
{
    public class CommonFunction
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        /// <summary>
        /// Giải mã dạng base 64
        /// </summary>
        /// <param name="base64EncodedData">Chuỗi ký tự dạng base64</param>
        /// <returns></returns>
        /// CreatedBy: NDBINH (01/03/2021)
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        /// <summary>
        /// Gọi API Server
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">url</param>
        /// <param name="action">Phương thức</param>
        /// <param name="contentType">Content type</param>
        /// <param name="jsonData">Data</param>
        /// <param name="header">Header</param>
        /// <returns></returns>
        public static T CallAPIService<T>(string url,string action,string contentType,string jsonData,Dictionary<string,string> header)
        {
            var httpWebrequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebrequest.Method = action;
            if (header != null && header.Count() > 0)
            {
                foreach (var item in header)
                {
                    httpWebrequest.Headers.Add(item.Key, item.Value);
                }
            }
            if (!action.ToLower().Equals("get"))
            {
                httpWebrequest.ContentType = contentType;
                if (contentType.ToLower().Equals("application/json"))
                {
                    httpWebrequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.190 Safari/537.36";
                    using (var stream = new StreamWriter(httpWebrequest.GetRequestStream()))
                    {
                        stream.Write(jsonData);
                        stream.Flush();
                        stream.Close();
                    }
                }
                if (contentType.ToLower().Equals("application/x-www-form-urlencoded"))
                {
                    using (var stream = httpWebrequest.GetRequestStream())
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(jsonData);
                        stream.Write(bytes, 0, bytes.Length);
                        stream.Flush();
                        stream.Close();
                    }
                }
            }
            //using (HttpWebResponse httpResponse = (HttpWebResponse)httpWebrequest.GetResponse())
            //{
            //    using (Stream stream = httpResponse.GetResponseStream())
            //    {
            //        string result = (new StreamReader(stream)).ReadToEnd();
            //        return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
            //    }
            //}

            var httpResPonse = (HttpWebResponse)httpWebrequest.GetResponse();
            using (var streamReader = new StreamReader(httpResPonse.GetResponseStream()))
            {
                var resultstring = streamReader.ReadToEnd();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(resultstring);
            }




        }
        public static string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());
            return String.Join("&", properties.ToArray());
        }
    }
}
