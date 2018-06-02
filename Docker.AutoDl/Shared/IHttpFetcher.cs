using System;
using System.Collections.Generic;
using System.Text;

namespace Docker.AutoDl.Shared
{
    public interface IHttpFetcher
    {
        string getPage(string url);
    }
}
