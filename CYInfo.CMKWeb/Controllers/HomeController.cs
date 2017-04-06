using CYInfo.CMKWeb.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;

namespace CYInfo.CMKWeb.Controllers
{
    //[Authorize]

    [LogActionFilter]
    public class HomeController : Controller
    {
        static string apiUrl = ConfigurationManager.AppSettings["ApiUrl"].ToString();

        public ActionResult Index()
        {
            string returnMessage = string.Empty;
             List<Brand> brandList = new List<Brand>();
             Brand brand = new Brand();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);//测试环境
                    returnMessage = client.GetAsync("/api/GetBrands").Result.Content.ReadAsStringAsync().Result;


                   JObject returnJsonEntities= JObject.Parse(returnMessage);

                  

                   List<Dictionary<string, object>> dataList = new List<Dictionary<string, object>>();
                   dataList = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(returnJsonEntities["Message"].ToString());

                   List<Dictionary<string, string>> brandNameList = new List<Dictionary<string, string>>();
                  

                  

                    foreach(var entity in dataList)
                    {
                        Console.WriteLine(entity.ToString());
                        brand = new Brand();
                        brand.BrandPrefix = entity["BrandPrefix"].ToString();
                        brandNameList = new List<Dictionary<string, string>>();
                       
                        brandNameList=JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(entity["Brands"].ToString());
                        foreach (var brandEntity in brandNameList)
                        {
                            brand.BrandName.Add(brandEntity["BrandName"]);
                        }

                        brandList.Add(brand);
                    }

                   
                }
            }
            catch (Exception ex)
            {

            }
            return View(brandList);
        }
    }
}
