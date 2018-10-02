using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;


namespace Template.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new StyleBundle("~/bundles/css").Include(
            //                                            "~/Content/css/main.css",
            //                                            "~/Content/css/style.css"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/animations.css",
                "~/Content/css/fonts.css",
                "~/Content/css/main.css",
                "~/Content/css/shop.css"
                ));

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                "~/js/jquery.min.js",
                "~/js/main.js",
                "~/js/jquery.skel.min.js",
                "~/js/skel-layers.min.js",
                "~/js/init.js",                               
                "~/js/modernizr-2.6.2.min.js"
                ));
            // add ScriptBundle here..  

            // create an object of ScriptBundle and 
            // specify bundle name (as virtual path) as constructor parameter 
            ScriptBundle scriptBndl = new ScriptBundle("~/Content/Vendor/bootstrap");

            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include("~/Content/js/compressed.js",
                "~/Content/js/selectize.min.js",
                "~/Content/js/main.js"));
            ////use Include() method to add all the script files with their paths 
            //scriptBndl.Include("~/Content/js/main.js",
            //                    "~/Content/js/modernizr-2.6.2min.js");


            //Add the bundle into BundleCollection
            bundles.Add(scriptBndl);

            BundleTable.EnableOptimizations = true;

        }
    }
}