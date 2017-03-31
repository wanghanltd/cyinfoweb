using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CYInfo.CMKWeb.Models
{
    public class Brand
    {

        public Brand()
        {
            BrandName = new List<string>();
        }
        public string BrandPrefix { get; set; }

        public List<string> BrandName { get; set; }


    }

    

}