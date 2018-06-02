using System;
using System.Collections.Generic;
using System.Linq;
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

        public static implicit operator Season(TraktSeason trakt)
        {
            var season = new Season()
            {
                SeasonNumber = trakt.Season,
                MissingEpisodes = trakt.MissingEpisodes.Where(e => e.Episode.HasValue).Select(e => e.Episode.Value).ToList()
            };

            return season;
        }
    }
}
