using DllConsumedByNuget.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllConsumedByNuget
{
    public static class ConfigFromChildDll
    {

        public static string GetConfig() => Resources.settings;

    }
}
