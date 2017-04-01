using CYInfo.CMKWeb.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CYInfo.CMKWeb.Controllers
{
    public class SizeChartsController : Controller
    {

        static string apiUrl = ConfigurationManager.AppSettings["ApiUrl"].ToString();

        // GET: SizeCharts
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetSiezeChartByBrandName(string brandName)
        {

            BrandSizeChart brandSizeChart = new BrandSizeChart();
            try
            {
                Dictionary<string, string> dataDic = new Dictionary<string, string>();
                dataDic.Add("BrandName", brandName);
                string returnMessage = string.Empty;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);//测试环境

                    var content = new StringContent(JsonConvert.SerializeObject(dataDic), Encoding.UTF8, "application/json");

                    returnMessage = client.PostAsync("/api/GetBrandSizeChart", content).Result.Content.ReadAsStringAsync().Result;
                    JObject returnJsonEntities = JObject.Parse(returnMessage);

                    Dictionary<string, string> sizeChartDic = new Dictionary<string, string>();
                    sizeChartDic = JsonConvert.DeserializeObject<Dictionary<string, string>>(returnJsonEntities["Message"].ToString());

                    brandSizeChart.BrandName = sizeChartDic["BrandName"].ToString();

                    if(sizeChartDic.ContainsKey("Women"))
                    {
                        brandSizeChart.Women = sizeChartDic["Women"].ToString();
                    }
                    if (sizeChartDic.ContainsKey("Men"))
                    {
                        brandSizeChart.Men = sizeChartDic["Men"].ToString();
                    }
                    if(sizeChartDic.ContainsKey("Kids"))
                    {
                        brandSizeChart.Kids = sizeChartDic["Kids"].ToString();
                    }
                    if(sizeChartDic.ContainsKey("Baby"))
                    {
                        brandSizeChart.Baby = sizeChartDic["Baby"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return View(brandSizeChart);
        }
    }
}