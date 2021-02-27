using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.JETPAY.DemoPaymentGateway.Models
{
    public class ResultNapas
    {
        /// <summary>
        /// Id merchant
        /// </summary>
        public string merchantId { get; set; }

        /// <summary>
        /// Số tiền thanh toán
        /// </summary>
        public double orderAmout { get; set; }

        /// <summary>
        /// Id đơn hàng
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// Trạng thái thanh toán
        /// </summary>
        public string result { get; set; }
    }
}
