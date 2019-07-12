using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;

namespace WpfApp5
{
	public class AppBootstrapper : UnityBootstrapper
	{
		private MainController _controller;

		protected override void ConfigureModuleCatalog()
		{
			base.ConfigureModuleCatalog();

			ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
			moduleCatalog.AddModule(typeof(SampleModule));
		}

		protected override DependencyObject CreateShell()
		{
			_controller = new MainController();
			this.Container.RegisterInstance<MainController>(_controller);

			// Use the container to create an instance of the shell.
			MainWindow view = this.Container.TryResolve<MainWindow>();
			//view.DataContext = new MainWindowViewModel(new MainController());
			return view;
		}

		protected override void InitializeShell()
		{
			base.InitializeShell();
			App.Current.MainWindow = (Window)this.Shell;
			App.Current.MainWindow.Show();
		}

		protected override Prism.Regions.IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
		{
			var factory = base.ConfigureDefaultRegionBehaviors();
			return factory;
		}
	}

}
