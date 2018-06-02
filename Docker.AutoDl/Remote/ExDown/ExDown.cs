using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Docker.AutoDl.Shared;
using Docker.AutoDl.Shared.Remote.ExDown;
using HtmlAgilityPack;

namespace Docker.AutoDl.Remote.ExDown
{
    public class ExDown : IUrlFetcher
    {
        public const string BASE_URL = "https://www.extreme-d0wn.com/";
        public const string ALPHA_URL = "alpha/";

        private IHttpFetcher _Http { get; set; }

        public ExDown(IHttpFetcher http)
        {
            _Http = http;
        }

        public List<string> getDlUrl(List<Show> shows)
        {
            foreach (var show in shows)
            {
                var firstLetter = show.SerieName.Substring(0, 1).ToLower();

                var indexUrl = string.Concat(BASE_URL, ALPHA_URL, firstLetter);

                var res = _Http.getPage(indexUrl + "/0");

                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(res);

                var pagesNumbersNodes = htmlDoc.DocumentNode.SelectNodes("//div")
                    .SingleOrDefault(div => div.HasClass("navigation") && div.HasClass("ignore-select"));

                if (pagesNumbersNodes != null)
                {
                    var nextNode = pagesNumbersNodes.SelectNodes("a").SingleOrDefault(n => n.InnerText == "Suivant &#8594;");

                    if (nextNode != null)
                    {
                        Console.WriteLine("Numbers pages: " + nextNode.PreviousSibling.PreviousSibling.InnerText);
                    }
                    else
                    {
                        Console.WriteLine("Bad News");
                    }
                }
                else
                {
                    Console.WriteLine("Only page 0");
                }
            }


            return null;
        }
    }
}
