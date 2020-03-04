using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Ninject;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StandardKernel kernel = new StandardKernel();

            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = new Presenter(kernel);
            
            kernel.Bind<Model.IPresenter>().ToConstant(presenter);
            kernel.Bind<View.IPresenter>().ToConstant(presenter);

            var form = new View.KD(kernel);
            
            kernel.Bind<View.IView>().ToConstant(form);
            kernel.Bind<Model.IModel>().ToConstant(new Model.Model(kernel));

            presenter.bind();
            
            
            Application.Run(form);
        }
    }
}
