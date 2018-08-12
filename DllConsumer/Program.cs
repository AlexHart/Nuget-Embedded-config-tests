using NugetProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var configUser = new ConfigUser();
            var config = configUser.ReadConfigFile(AppEnvironment.Local);

            Console.WriteLine(config);
        }
    }
}
