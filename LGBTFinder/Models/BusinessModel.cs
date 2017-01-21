using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LGBTFinder.Models
{
    public class BusinessModel
    {
        public enum BusinessTypeEnum
        {
            Restaurant,
            Clothing,
            CoffeeShop,
            Hotel,
            Hostel,
            RetailStore,
            Bar,
            Nightclub,
            All,
            Other
        };

        public enum BusinessDistanceEnum
        {
            One = 1,
            Five = 5,
            Ten = 10,
            TwentyFive = 25,
            Fifty = 50,
            OneHundred = 100,
            Any 

        };

        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Business Description")]
        public string BusinessDescription { get; set; }

        [Display(Name = "Image")]
        public Guid Image { get; set; }

        public Address Address { get; set; }

        [Display(Name = "Website Address")]
        public string WebsiteAddress { get; set; }

        [Display(Name = "Contact Email Address")]
        public string ContactEmail { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        
    }
}