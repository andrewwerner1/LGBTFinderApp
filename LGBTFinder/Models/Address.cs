using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;

namespace LGBTFinder.Models
{
    public class Address
    {

        public enum States { AL, AK, AZ, AR, CA, CO, CT, DE, FL, GA, HI, ID, IL, IN, IA, KS, KY, LA, ME, MD, MA, MI, MN, MS, MO, MT, NE, NV, NH, NJ, NM, NY, NC, ND, OH, OK, OR, PA, RI, SC, SD, TN, TX, UT, VT, VA, WA, WV, WI, WY };

        [Display(Name = "Address Line1")]
        public string Line1 { get; set; }

        [Display(Name = "Address Line2")]
        public string Line2 { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public States State { get; set; }

        [Display(Name = "Zipcode")]
        public int Zipcode { get; set; }


    }
}