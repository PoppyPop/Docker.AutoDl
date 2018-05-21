using System;
using System.Collections.Generic;
using System.Text;
using TraktApiSharp.Enums;

namespace Docker.AutoDl.Shared
{
    public class TraktSeason
    {
        public int? Season { get; set; }

        public bool Hidden { get; set; }

        public List<MissingEpisode> MissingEpisodes { get; set; }

        public TraktSeason()
        {
            MissingEpisodes = new List<MissingEpisode>();
        }
    }
}
