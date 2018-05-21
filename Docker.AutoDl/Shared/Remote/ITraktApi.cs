using System;
using System.Collections.Generic;
using System.Text;

namespace Docker.AutoDl.Shared
{
    public interface ITraktApi
    {
        string GetMode { get; }

        /// <summary>
        /// Get the missing episodes
        /// </summary>
        /// <returns></returns>
        List<TraktShow> GetMissingEpisodes();
    }
}
