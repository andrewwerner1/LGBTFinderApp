using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LGBTFinder.Models
{
    public class BusinessModel
    {
        public enum Type { Restaurant, Clothing, CoffeeShop, Hotel, HardwareStore, Other  };

        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        public Address Address { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Business Type")]
        public Type BusinessType { get; set; }


        
    }
}