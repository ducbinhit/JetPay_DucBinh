using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.JetPayWebsite.Models
{
    /// <summary>
    /// Class to defile object to call to API RegisterIntegrate
    /// </summary>
    /// Created by: NVThanh 08/03/2019
    public class RegisterIntegrateInfo
    {
        /// <summary>
        /// Id of service
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// Customer email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Customer mobile
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Customer full name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Content register
        /// </summary>
        public string Content { get; set; }
    }
}