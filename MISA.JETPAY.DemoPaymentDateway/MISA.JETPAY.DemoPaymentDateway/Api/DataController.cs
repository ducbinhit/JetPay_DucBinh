using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.JETPAY.DemoPaymentGateway.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.JETPAY.DemoPaymentGateway.Api
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {

        /// <summary>
        /// Lấy dữ liệu data trả về từ napas
        /// </summary>
        /// <returns>Danh sách data</returns>
        /// CreatedBy: NDBINH (29/02/2021)
        [HttpGet]
        public IActionResult Get()
        {
            // Kết nối với database:
            var connectionString = "User Id=dev;Host=47.241.69.179;Port=3306;Database=test;Password=12345678;Character Set=utf8";
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            // Lấy dữ liệu từ database:
            var datas = dbConnection.Query<DataNapas>("Proc_GetDatas", commandType: CommandType.StoredProcedure);
            // Trả dữ liệu lại cho Client:
            return Ok(datas);
        }

        /// <summary>
        /// Lấy thông tin data theo id
        /// </summary>
        /// <param name="dataId">Id data</param>
        /// <returns></returns>
        /// CreatedBy: NDBINH (28/02/2021)
        [HttpGet("{dataId}")]
        public IActionResult GetData(Guid dataId)
        {
            // Khai báo thông tin kết nối
            var connectionString = "User Id=dev;Host=47.241.69.179;Port=3306;Database=test;Password=12345678;Character Set=utf8";
            // khởi tạo đối tượng kết nối tới Database
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            // Thực hiện query lấy dữ liệu
            var data = dbConnection.Query<DataNapas>($"SELECT *FROM Data where DataId = '{dataId.ToString()}'", commandType: CommandType.Text).FirstOrDefault();
            // Trả về cho Client
            return Ok(data);
        }

        /// <summary>
        /// Thêm mới data
        /// </summary>
        /// <param name="dataNapas">Dữ liệu data thêm mới</param>
        /// <returns></returns>
        /// CreatedBy: NDBINH (28/02/2021)
        [HttpPost]
        public IActionResult Post([FromBody] DataNapas dataNapas)
        {
            // Khai báo thông tin kết nối tới máy chủ MariaDb
            var connectionString = "User Id=dev;Host=47.241.69.179;Port=3306;Database=test;Password=12345678;Character Set=utf8";
            // Khởi tạo đối tượng kết nối
            IDbConnection dbConnection = new MySqlConnection(connectionString);

            // Cách 1
            //var storeParamObject = new
            //{
            //    dataId = dataNapas.dataId.ToString(),
            //    merchantId = dataNapas.merchantId,
            //    amount = dataNapas.amount,
            //    creationTime = dataNapas.creationTime,
            //    currency = dataNapas.currency,
            //    id = dataNapas.id,
            //    result = dataNapas.result,
            //    nameOnCard = dataNapas.nameOnCard,
            //    issueDate = dataNapas.issueDate,
            //    number = dataNapas.number,
            //    date = dataNapas.date,
            //    dateCreated = dataNapas.dateCreated
            //};

            //Cách 2
            DynamicParameters dynamicParameters = new DynamicParameters();
            // Lấy tất cả property
            var properties = dataNapas.GetType().GetProperties();
            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(dataNapas);
                if(property.PropertyType == typeof(Guid))
                {
                    propertyValue = property.GetValue(dataNapas).ToString();
                }
                dynamicParameters.Add($"@{propertyName}", propertyValue);
            }
            // Thực hiện câu truy vấn thêm mới vào db
            var res = dbConnection.Execute("Proc_InsertData", commandType: CommandType.StoredProcedure, param:dynamicParameters);
            // Trả kết quả về cho Client
            return Ok(res);
        }
    }
}
