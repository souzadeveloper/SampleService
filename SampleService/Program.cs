using System.ServiceProcess;

namespace SampleService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SampleService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
