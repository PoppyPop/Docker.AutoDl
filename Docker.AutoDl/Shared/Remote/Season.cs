using System.Collections.Generic;

namespace Docker.AutoDl.Shared
{
    public class Season
    {
        public int? SeasonNumber { get; set; }

        public List<int> MissingEpisodes { get; set; }

        public Season()
        {
            MissingEpisodes = new List<int>();
        }
    }
}
