using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OfflineAppSample.Controllers
{
    public class OfflineController : Controller
    {
        //
        // GET: /Offline/

        public ActionResult Index()
        {
            return Content("offline");
        }

    }
}
