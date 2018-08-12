using NugetProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DllConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var configUser = new ConfigUser();
            var config = configUser.ReadConfigFile(AppEnvironment.Local);
            WriteLine(config);

            WriteLine("----------------");

            var childConfig = configUser.ReadConfigFromChildDll(AppEnvironment.Local);
            WriteLine(childConfig);

            WriteLine("----------------");
        }
    }
}
