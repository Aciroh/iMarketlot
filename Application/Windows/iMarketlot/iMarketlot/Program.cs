using iMarketlot.EventHandlers;
using iMarketlot.Forms;
using iMarketlot.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iMarketlot
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormSplash splash= new FormSplash();
            Application.Run(splash);
            Configurator.run();
            FormiMarketlot formiMarketlot = new FormiMarketlot();
            Thread formThread = new Thread(new ParameterizedThreadStart(startMainForm));
            formThread.Start(formiMarketlot);
            ChatLogServerHandler chatLogServerHandler = new ChatLogServerHandler(formiMarketlot);
        }

        private static void startMainForm(object o)
        {
            FormiMarketlot formiMarketlot = (FormiMarketlot)o;
            Application.Run(formiMarketlot);
        }
    }
}
