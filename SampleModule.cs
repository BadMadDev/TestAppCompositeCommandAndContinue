using System;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace WpfApp5
{
	public class SampleModule : IModule
	{
		private readonly IUnityContainer _container;
		private readonly IRegionManager _regionManager;

		public SampleModule(IUnityContainer container, IRegionManager regionManager)
		{
			_container = container ?? throw new ArgumentNullException(nameof(container));
			_regionManager = regionManager ?? throw new ArgumentNullException(nameof(regionManager));
		}

		public void Initialize()
		{
			_regionManager.RegisterViewWithRegion("CompositeRegion",
				() => _container.Resolve<AView>());
			_regionManager.RegisterViewWithRegion("CompositeRegion",
				() => _container.Resolve<BView>());
		}
	}
}
