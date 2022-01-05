using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Scanner
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Authentication authenticationForm = new Authentication();
            if (authenticationForm.ShowDialog() == DialogResult.OK)
            {
                Scanner form = new Scanner();
                Presenter presenter = new Presenter(form);
                Application.Run(form);
            }
        }
    }
}
