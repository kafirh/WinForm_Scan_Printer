using PrintPackingLabel._Repositories;
using PrintPackingLabel.Model;
using PrintPackingLabel.Presenter;
using PrintPackingLabel.View;
using System.Configuration;

namespace PrintPackingLabel
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
            //ApplicationConfiguration.Initialize();
            //.Run(new PrintPackingLabelView());

            ApplicationConfiguration.Initialize();
            ILoginView view = new LoginView();
            ILoginRepository repository = new LoginRepository();
            new LoginPresenter(view, repository);
            Application.Run((Form)view);
            //Application.Run(new FontViewer());
        }
    }
}