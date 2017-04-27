using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace CYInfo.CMKWeb
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.validation.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/sammy-{version}.js",
                "~/Scripts/app/common.js",
                "~/Scripts/app/app.datamodel.js",
                "~/Scripts/app/app.viewmodel.js",
                "~/Scripts/app/home.viewmodel.js",
                "~/Scripts/app/_run.js"));


            bundles.Add(new ScriptBundle("~/bundles/redscarf2").Include(

               "~/Scripts/redscarf2/blocksit.min.js",
               "~/Scripts/redscarf2/jquery-1.7.1.min.js",
               "~/Scripts/redscarf2/jquery-ias.min.js",
               "~/Scripts/redscarf2/jquery.colorbox-min.js",
               "~/Scripts/redscarf2/jquery.flexisel.js",
               "~/Scripts/redscarf2/jquery.flexnav.min.js",
               "~/Scripts/redscarf2/jquery.lazyload.min.js",
               "~/Scripts/redscarf2/jquery.sooperfish.min.js",
               "~/Scripts/redscarf2/modal.js",
               "~/Scripts/redscarf2/modernizr.js",
               "~/Scripts/redscarf2/scripts.js"));


            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/bootstrap.css",
                 "~/Content/combine.css",
                 "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/redscarf2").Include(
                "~/Content/redscarf2/colorbox.css",
                "~/Content/redscarf2/flexisel.css",
                "~/Content/redscarf2/flexnav.css",

                "~/Content//redscarf2/Site.css"));

        }
    }
}
