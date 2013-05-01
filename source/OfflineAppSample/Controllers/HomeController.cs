using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OfflineAppSample.Controllers
{
    public class HomeController : Controller
    {

        SyndicationService _service = new SyndicationService();

        //
        // GET: /Home/

        public ActionResult Index(string id)
        {
            if (id == null)
            {
                if (Request.Cookies.AllKeys.Contains("appcacheUpdate"))
                {
                    return View("AppCacheUpdate");
                }
                else
                {
                    var articles = _service.Get();
                    return View(articles);
                }
            }
            else
            {
                var article = _service.Get(id);
                return View("Article", article);
            }
        }
    }
}
