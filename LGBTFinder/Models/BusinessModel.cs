using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LGBTFinder.Models
{
    public class BusinessModel
    {
        public enum BusinessTypeEnum { Restaurant, Clothing, CoffeeShop, Hotel, HardwareStore, Other  };

        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        public Address Address { get; set; }

        [Display(Name = "Website Address")]
        public string WebsiteAddress { get; set; }

        [Display(Name = "Contact Email Address")]
        public string ContactEmail { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        
    }
}