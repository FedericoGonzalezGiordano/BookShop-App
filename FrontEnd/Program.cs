using FrontEnd.Factory.Implementation;
using FrontEnd.View.Login;

namespace FrontEnd
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin(new FactoryService()));
            //Application.Run(new FrmCustomerRegistration(new FactoryService()));
        }
    }
}