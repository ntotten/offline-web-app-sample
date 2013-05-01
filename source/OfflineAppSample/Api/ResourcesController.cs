using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Optimization;

namespace OfflineAppSample.Api
{
    public class ResourcesController : ApiController
    {

        public object Get()
        {
            var context = new BundleContext(new HttpContextWrapper(HttpContext.Current), BundleTable.Bundles, "~/");
            var css = BundleTable.Bundles.GetBundleFor("~/Content/css").GenerateBundleResponse(context).Content;
            var js = BundleTable.Bundles.GetBundleFor("~/bundles/resources").GenerateBundleResponse(context).Content;
            return new
            {
                css = css,
                js = js
            };
        }

    }
}
