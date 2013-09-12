
namespace Mailing
{
    class Helper
    {
        internal static string CurrentWindowsUser
        {
            get { return System.Security.Principal.WindowsIdentity.GetCurrent().Name; }
        }

        internal static void ErrorFile(string msg)
        {
            System.IO.StreamWriter sw = System.IO.File.AppendText(Config.errorFile);
            try
            {
                string logLine = System.String.Format("{0:G}: {1}.", System.DateTime.Now, msg);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }
        }

        internal static void LogFile(string msg)
        {
            try
            {
                System.IO.File.WriteAllText(Config.logFile, msg);
            }
            catch (System.Exception e)
            {
                Helper.ErrorFile(e.ToString());
            }
        }

        internal static void LogFileLine(int linea, string msg)
        {
            try
            {
                string[] lineas = System.IO.File.ReadAllLines(Config.logFile);
                lineas[linea - 1] = msg;
                System.IO.File.WriteAllLines(Config.logFile, lineas);
            }
            catch (System.Exception e)
            {
                Helper.ErrorFile(e.ToString());
            }
        }
    }
}
