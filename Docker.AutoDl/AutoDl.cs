using System;
using System.Collections.Generic;
using System.Composition;
using System.Text;
using Docker.AutoDl.Shared;
using Docker.AutoDl.Shared.Remote.ExDown;

namespace Docker.AutoDl
{
    public class AutoDl : IAutoDl
    {
        private ITrackingApi TraktApi { get; set; }
        private IEnumerable<IUrlFetcher> Fetchers { get; set; }

        public AutoDl(ITrackingApi traktApi, IEnumerable<IUrlFetcher> fetchers)
        {
            TraktApi = traktApi;
            Fetchers = fetchers;
        }

        public void Run()
        {
            Console.WriteLine(TraktApi.GetMode);

            var missingEpisodes = TraktApi.GetMissingEpisodes();

            foreach (var fetcher in Fetchers)
            {
                fetcher.getDlUrl(missingEpisodes);
            }

        }
    }
}
