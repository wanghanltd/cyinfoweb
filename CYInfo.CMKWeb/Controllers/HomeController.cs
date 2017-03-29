using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;

namespace CYInfo.CMKWeb.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        static string apiUrl = ConfigurationManager.AppSettings["ApiUrl"].ToString();

        public ActionResult Index()
        {
            string returnMessage = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);//测试环境
                    returnMessage = client.GetAsync("/api/GetBrands").Result.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {

            }
            return Content(returnMessage);
        }
    }
}
