using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CYInfo.CMKWeb.Models
{
    public class BrandSizeChart
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public virtual string Id { get; set; }


        /// <summary>
        /// 品牌名
        /// </summary>
        [Display(Name = "品牌名")]
        public string BrandName { get; set; }

        /// <summary>
        /// 尺码表
        /// </summary>
        [Display(Name = "尺码表")]
        public List<SizeChart> SizeCharts { get; set; }
       



    }


    public class SizeChart
    {
        [Display(Name = "Gender")]
        public string Gender { get; set; }


        [Display(Name = "Chart")]
        public string Chart { get; set; }
    }
}