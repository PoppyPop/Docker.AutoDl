using System.Collections.Generic;
using Docker.AutoDl.Shared;

namespace Docker.AutoDl.Mock.Remote.Trakt
{
    public class TraktApi : ITraktApi
    {
        public string GetMode => "Mock";

        public List<TraktShow> GetMissingEpisodes()
        {
            List<TraktShow> result = new List<TraktShow>();

            result.Add(new TraktShow
            {
                Id = 360,
                SerieName = "Doctor Who",
                Providers = new Dictionary<string, string> { { "Imdb", "tt0436992" }, { "Tmdb", "57243" } },
                //MissingEpisodes = new List<MissingEpisode> { new MissingEpisode { Episode = 1, Season = 9 } }

            });

            return result;
        }
    }
}
