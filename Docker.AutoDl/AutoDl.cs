using System;
using System.Collections.Generic;
using System.Composition;
using System.Text;
using Docker.AutoDl.Shared;

namespace Docker.AutoDl
{
    public class AutoDl : IAutoDl
    {
        private ITraktApi TraktApi { get; set; }

        public AutoDl(ITraktApi traktApi)
        {
            TraktApi = traktApi;
        }

        public void Run()
        {
            Console.WriteLine(TraktApi.GetMode);

            TraktApi.GetMissingEpisodes();


            //throw new NotImplementedException();
        }
    }
}
