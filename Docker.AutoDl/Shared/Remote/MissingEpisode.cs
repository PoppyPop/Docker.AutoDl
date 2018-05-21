using System;
using System.Collections.Generic;
using System.Text;

namespace Docker.AutoDl.Shared
{
    public class MissingEpisode
    {
        public int? Episode { get; set; }

        public bool Watched { get; set; }

        public bool Collected { get; set; }
    }
}
