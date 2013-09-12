using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mailing
{
    static internal class Config
    {
        internal const int mailingMaxOffset = 10;
        internal const int mailingWait = 5;

        internal static string currentDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        internal static string templateFile = currentDir + @"\template.html";
        internal const string templateMarker = "{TEXTO_EMAIL}";

        internal static string logFile = String.Format(@"{0}\{1}.log",currentDir,AssemblyInfo.AssemblyProduct);
        internal static string errorFile = String.Format(@"{0}\error.log", currentDir);
    }
}
