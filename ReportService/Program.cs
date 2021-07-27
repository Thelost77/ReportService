using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ReportService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string [] args)
        {
            if (Environment.UserInteractive)
            {
                var parameter = string.Concat(args);
                switch(parameter)
                {
                    case "--install":
                        ManagedInstallerClass.InstallHelper(new[]{ Assembly.GetExecutingAssembly().Location});
                        break;
                    case "--uninstall":
                        ManagedInstallerClass.InstallHelper(new[] { "/u", Assembly.GetExecutingAssembly().Location });
                        break;
                }
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new ReportService()
                };
                ServiceBase.Run(ServicesToRun);
            }            
        }
    }
}
