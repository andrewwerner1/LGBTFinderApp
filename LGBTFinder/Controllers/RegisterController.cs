using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using LGBTFinder.Models;

namespace LGBTFinder.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            BusinessModel model = new BusinessModel();
            return View();
        }

        public string PrintAllBusinessModelProps()
        {
            BusinessModel model = new BusinessModel();
            string output = string.Empty;
            output = PrintAllBusinessModelPropsHelper(model.GetType(), ref output);
            return output;
        }

        public string PrintAllBusinessModelPropsHelper(Type objType, ref string output, bool nested = false)
        {

            PropertyInfo[] props = objType.GetProperties();
            for (int i = 0; i < props.Length; i++)
            {
                PropertyInfo prop = props[i];

                if (IsSimpleType(prop.PropertyType))
                {
                    
                    if (i == props.Length - 1 && !nested)
                    {
                        output += prop.Name;
                    }
                    else
                    {
                        output += prop.Name + ", ";
                    }
                }
                else
                {
                    var propertyType = prop.PropertyType;
                    PrintAllBusinessModelPropsHelper(propertyType, ref output, true);
                }
            }
            return output;
        }

        public bool IsSimpleType(Type type)
        {
            if (type == typeof(string))
            {
                return true;
            }
            if (type == typeof(int) || type == typeof(double) || type == typeof(float))
            {
                return true;
            }
            if (type == typeof(DateTime))
            {
                return true;
            }
            return false;
        }
    }
}