using OfflineAppSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Web.Http;
using System.Xml;
using System.Xml.Linq;

namespace OfflineAppSample.Api
{
    public class ArticlesController : ApiController
    {
        SyndicationService _service = new SyndicationService();

        // GET api/articles
        public IEnumerable<Article> Get()
        {
            return _service.Get();
        }

        // GET api/articles/5
        public Article Get(string id)
        {
            return _service.Get(id);
        }

    }
}
