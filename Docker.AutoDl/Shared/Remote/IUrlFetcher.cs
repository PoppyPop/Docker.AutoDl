using System;
using System.Collections.Generic;
using System.Text;

namespace Docker.AutoDl.Shared.Remote.ExDown
{
    public interface IUrlFetcher
    {
        List<string> getDlUrl(List<Show> shows);
    }
}
