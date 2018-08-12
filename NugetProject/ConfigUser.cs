using NugetProject.Properties;
using DllConsumedByNuget;

namespace NugetProject
{

    public enum AppEnvironment
    {
        Local = 0,
        Int = 1,
        Acc = 2,
        Sta = 3,
        Pro = 4
    }

    public class ConfigUser
    {

        /// <summary>
        /// Read the config file.
        /// </summary>
        /// <returns></returns>
        public string ReadConfigFile(AppEnvironment environment)
        {
            string config;
            switch(environment)
            {
                case AppEnvironment.Pro:
                    config = Resources.azureconfig_PRO;
                    break;
                default:
                    config = Resources.azureconfig;
                    break;
            }
            return config;
        }

        /// <summary>
        /// Read the config that is embedded inside a child dll.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        public string ReadConfigFromChildDll(AppEnvironment environment) =>
            ConfigFromChildDll.GetConfig();


    }
}
