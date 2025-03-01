using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace StackOverflowProject
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/Scripts/jquery").Include("~/Scripts/umd/jquery.3.7.1.js", "~/Scripts/umd/popper.js", "~/Scripts/umd/bootstrap.js"));
			bundles.Add(new StyleBundle("~/Styles/bootstrap").Include("~/Content/bootstrap.css"));
			bundles.Add(new StyleBundle("~/Styles/site").Include("~/Content/Styles.css"));
			BundleTable.EnableOptimizations = true;
        }
	}
}