using FoodPlanning.App.AppCore;
using FoodPlanning.Common.ApplicationCore;
using TinyIoC;
using XLabs.Ioc;
using XLabs.Ioc.TinyIOC;
using XLabs.Platform.Device;

namespace FoodPlanning.Android
{
    public class AppBootstrapper
    {
        private readonly TinyContainer tinyContainer;

        public AppBootstrapper()
        {
            TinyIoCContainer container = TinyIoCContainer.Current;

            tinyContainer = new TinyContainer(container);

            container.Register<IDependencyContainer>(tinyContainer);

            if (!Resolver.IsSet)
                Resolver.SetResolver(new TinyResolver(container));
        }

        public void SetupApplication()
        {
            var app = Resolver.Resolve<IAppSettings>();

            if (app != null)
                return;

            DependencyInjectionSetup.SetupCore();

            tinyContainer.RegisterSingle<IAppSettings, AppSettings>();

        }
    }
}