using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AMS
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        //protected override void ConfigureModuleCatalog()
        //{
        //    ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
        //    catalog.AddModule(typeof(ModuleAModule));
        //}

    }
}
