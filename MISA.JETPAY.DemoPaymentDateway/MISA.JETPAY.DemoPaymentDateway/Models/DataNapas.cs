using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.JETPAY.DemoPaymentGateway.Models
{
    public class DataNapas
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid dataId { get; set; }

        /// <summary>
        /// Id merchant
        /// </summary>
        public string merchantId { get; set; }

        /// <summary>
        /// Số tiền thanh toán
        /// </summary>
        public string amount { get; set; }

        /// <summary>
        /// Thời gian thanh toán
        /// </summary>
        public DateTime? creationTime { get; set; }

        /// <summary>
        /// Loại tiền thanh toán
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Id đơn hàng
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Trạng thái thanh toán
        /// </summary>
        public string result { get; set; }

        /// <summary>
        /// Tên chủ thẻ
        /// </summary>
        public string nameOnCard { get; set; }

        /// <summary>
        /// Tháng năm đăng ký ddyy
        /// </summary>
        public string issueDate { get; set; }

        /// <summary>
        /// Số in trên thẻ
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// Thời gian hoàn thành thanh toán
        /// </summary>
        public DateTime? date { get; set; }

        /// <summary>
        /// Ngày giờ tạo bản ghi
        /// </summary>
        public DateTime? dateCreated { get; set; }
    }
}
