using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEx.WinFormsUI
{
    public enum VersionType
    {
        Beta, 
        Realese
    }

    public class GlobalConfigurations
    {
        public static string Version = "version - 0.5.0 - beta";
        public static VersionType VersionType = VersionType.Beta;
    }
}
