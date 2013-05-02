using OfflineAppSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace OfflineAppSample
{
    public class SyndicationService
    {

        public List<Article> Get()
        {
            SyndicationItem[] items;
            using (var reader = XmlReader.Create("http://blogs.msdn.com/b/windowsazure/rss.aspx?Tags=windows+azure/"))
            {
                var feed = SyndicationFeed.Load(reader);
                items = feed.Items.ToArray();
            }
            var articles = items.Take(10).Select(a => new Article
            {
                Id = a.Id,
                Headline = a.Title.Text,
                Date = a.PublishDate.UtcDateTime,
                Body = a.Summary.Text,
                Author = a.ElementExtensions.FirstOrDefault(e => e.OuterName == "creator") == null ?
                    null : a.ElementExtensions.FirstOrDefault(e => e.OuterName == "creator").GetObject<XElement>().Value
            });
            return articles.ToList();
        }

        public Article Get(string id)
        {
            return Get().Single(a => a.Id == id);
        }

    }
}