using System;
using System.Collections.Generic;
using System.Text;

namespace Docker.AutoDl.Shared
{
    public interface ITrackingApi
    {
        string GetMode { get; }

        /// <summary>
        /// Get the missing episodes
        /// </summary>
        /// <returns></returns>
        List<Show> GetMissingEpisodes();
    }
}
