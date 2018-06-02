using System;
using System.Collections.Generic;
using System.Text;
using TraktApiSharp;

namespace Docker.AutoDl.Shared
{
    public interface ITraktApiClient
    {
        string GetMode { get; }

        TraktClient Client { get; }
    }
}
