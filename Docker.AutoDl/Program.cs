using System;
using System.Composition;
using System.Composition.Convention;
using System.Composition.Hosting;
using System.Reflection;
using Docker.AutoDl.Mock.Remote;
using Docker.AutoDl.Remote.ExDown;
using Docker.AutoDl.Shared;
using Docker.AutoDl.Shared.Database;
using Docker.AutoDl.Shared.Remote.ExDown;

namespace Docker.AutoDl
{
    class Program
    {

        [Import]
        private IAutoDl AutoDl { get; set; }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Compose();
            p.AutoDl.Run();
            //Console.WriteLine(p.AutoDl.Text);

            Console.WriteLine("End");
            Console.ReadLine();
        }

        private void Compose()
        {
            var convention = new ConventionBuilder();

            #region Custom export

            convention.ForType<AutoDl>().Export<IAutoDl>();

            convention.ForType<Remote.Trakt.TraktApiClient>().Export<ITraktApiClient>();
            convention.ForType<Mock.Remote.Trakt.TraktApi>().Export<ITrackingApi>();

            convention.ForType<Database.SqLite.SqLiteDatabase>().Export<IDatabase>();
            convention.ForType<FileWebFetcher>().Export<IHttpFetcher>();

            convention.ForType<ExDown>().Export<IUrlFetcher>();

            #endregion

            var assemblies = new[] { typeof(Program).GetTypeInfo().Assembly };
            var configuration = new ContainerConfiguration()
                .WithAssemblies(assemblies, convention);

            using (var container = configuration.CreateContainer())
            {
                AutoDl = container.GetExport<IAutoDl>();
            }
        }
    }
}
