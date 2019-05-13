using System.Runtime.InteropServices;

namespace NetStandardUtils
{
    public static class Platform
    {
        /// <summary>
        /// Returns the current running archticture in a .NET like string
        /// </summary>
        public static string Arch
        {
            get
            {
                var arch = "";

                switch (RuntimeInformation.OSArchitecture)
                {
                    case Architecture.Arm:
                        arch += "arm";
                        break;
                    case Architecture.Arm64:
                        arch += "arm64";
                        break;
                    case Architecture.X64:
                        arch += "x64";
                        break;
                    case Architecture.X86:
                        arch += "x86";
                        break;
                }

                return arch;
            }
        }

        /// <summary>
        /// returns the runtime identifier
        /// </summary>
        public static string Rid
        {
            get
            {
                var rid = "";
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    rid = "linux-";
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    rid = "win-";
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    rid = "osx-";
                }

                rid += Arch;

                return rid;
            }
        }
    }
}
