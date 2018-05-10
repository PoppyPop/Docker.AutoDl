using System;
using System.Composition;
using System.Composition.Convention;
using System.Composition.Hosting;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Docker.AutoDl
{
    class Program
    {
        [Import]
        private IMefTest mef { get; set; }

        static void Main(string[] args)
        {

            var p =new Program();
            p.Run();


            Console.WriteLine("End");
            Console.ReadLine();
        }

        public void Run()
        {
            Compose();
            Console.WriteLine(mef.Text);
        }


        private void Compose()
        {
            var convention = new ConventionBuilder();

            #region Custom export

            convention.ForType<MefExport2>().Export<IMefTest>();


            convention.ForType<MefExportTest2>().Export<IMefTest2>();

            #endregion

            var assemblies = new[] { typeof(Program).GetTypeInfo().Assembly };
            var configuration = new ContainerConfiguration()
                .WithAssemblies(assemblies, convention);

            using (var container = configuration.CreateContainer())
            {
                mef = container.GetExport<IMefTest>();
            }
        }
    }
}
