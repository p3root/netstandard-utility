using System.Reflection;

namespace NetStandardUtils
{
    public static class Version
    {
        public static string GetAssemblyVersion()
        {
            return Assembly.GetCallingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }
    }
}
