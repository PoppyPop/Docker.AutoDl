using System;
using System.Collections.Generic;
using System.Text;
using TraktApiSharp.Enums;

namespace Docker.AutoDl.Shared
{
    public class TraktShow
    {
        public uint Id { get; set; }

        public string SerieName { get; set; }

        public int? Year { get; set; }

        public bool Watched { get; set; }

        public bool CollectionProgress { get; set; }

        public TraktShowStatus Status { get; set; }

        public Dictionary<string, string> Providers { get; set; }

        public List<TraktSeason> Seasons { get; set; }

        public TraktShow()
        {
            Providers = new Dictionary<string, string>();
            Seasons = new List<TraktSeason>();
        }
    }
}
