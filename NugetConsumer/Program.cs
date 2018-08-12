using NugetProject;
using System;

namespace NugetConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var configUser = new ConfigUser();
                var config = configUser.ReadConfigFile(AppEnvironment.Pro);

                Console.WriteLine(config);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
