using System;
using System.Collections.Generic;
using System.Text;
using Docker.AutoDl.Remote.ExDown;
using Docker.AutoDl.Shared;

namespace Docker.AutoDl.Mock.Remote
{
    public class FileWebFetcher : IHttpFetcher
    {
        public string getPage(string url)
        {
            string result = string.Empty;
            if (url == string.Concat(ExDown.BASE_URL, ExDown.ALPHA_URL, "w/0"))
            {
                result = System.IO.File.ReadAllText(@"Mock\Remote\ExDown\w.html");
            }

            if (url == string.Concat(ExDown.BASE_URL, ExDown.ALPHA_URL, "z/0"))
            {
                result = System.IO.File.ReadAllText(@"Mock\Remote\ExDown\z.html");
            }

            if (url == string.Concat(ExDown.BASE_URL, ExDown.ALPHA_URL, "9/0"))
            {
                result = System.IO.File.ReadAllText(@"Mock\Remote\ExDown\9.html");
            }

            return result;
        }
    }
}
