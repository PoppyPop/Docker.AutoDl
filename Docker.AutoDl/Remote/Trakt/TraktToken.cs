using System;
using System.Collections.Generic;
using System.Text;

namespace Docker.AutoDl.Remote.Trakt
{
    public class TraktToken
    {
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }
    }
}
