using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMTModifier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args == null)
            {
                Application.Run(new Form_Main(null));
            }
            else if (args.Length == 0)
            {
                Application.Run(new Form_Main(null));
            }
            else
            {
                Application.Run(new Form_Main(new StringValue(args[0])));
            }
        }
    }
}
