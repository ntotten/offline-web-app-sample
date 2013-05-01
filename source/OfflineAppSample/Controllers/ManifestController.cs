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
            sb.AppendLine(Scripts.Render("~/bundles/jquery").ToString().Replace("<script src=\"", "").Replace("\"></script>", ""));
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
