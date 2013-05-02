using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace OfflineAppSample.Controllers
{
    public class ManifestController : Controller
    {
        //
        // GET: /Manifest/

        public ActionResult Index()
        {
            var sb = new StringBuilder();
            sb.AppendLine("CACHE MANIFEST");
            sb.AppendLine("/Scripts/jquery-2.0.0.min.js");
            sb.AppendLine();
            sb.AppendLine("FALLBACK:");
            sb.AppendLine("/api /offline");
            sb.AppendLine("/ /");
            sb.AppendLine();
            sb.AppendLine("NETWORK:");
            sb.AppendLine("*");
            return Content(sb.ToString(), "text/cache-manifest");
        }

    }
}
