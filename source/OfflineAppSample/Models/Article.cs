using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfflineAppSample.Models
{
    public class Article
    {
        public string Id { get; set; }
        public string Headline { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
    }
}