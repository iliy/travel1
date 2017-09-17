using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebTrevel.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Clear();
            bundles.ResetAll();

            BundleTable.EnableOptimizations = false;

            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include("~/Scripts/jquery-1.10.2.min.js"));
            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/Scripts/angular").Include("~/Scripts/angular/angular.min.js"));
            bundles.Add(new ScriptBundle("~/Scripts/custom").Include("~/Scripts/custom-1.01.js"));
            bundles.Add(new ScriptBundle("~/Scripts/modernizr").Include("~/Scripts/modernizr-2.6.2.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/Site").Include("~/Content/Site.css"));
        }
    }
}