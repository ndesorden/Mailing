using System;
using System.Windows.Forms;

namespace Mailing
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            // Set the unhandled exception mode to force all Windows Forms errors to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ProcessException((Exception)e.ExceptionObject);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ProcessException(e.Exception);
        }

        public static void ProcessException(Exception e)
        {
            MessageBox.Show("Error: " + e.ToString(), "Se ha producido un error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
