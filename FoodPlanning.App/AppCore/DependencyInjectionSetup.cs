using FoodPlanning.Features.ApplicationCore;
using FoodPlanning.Features.FoodSchedule;
using FoodPlanning.Features.MainPage;
using FoodPlanning.Features.SignIn;
using XLabs.Ioc;

namespace FoodPlanning.App.AppCore
{
    public static class DependencyInjectionSetup
    {
        public static void SetupCore()
        {
            var container = Resolver.Resolve<IDependencyContainer>();

            // Base View Models
            container.RegisterSingle<IBaseViewModel, BaseViewModel>();

            // Specific Page View Models
            container.Register<ISignInViewModel, SignInViewModel>();
            container.Register<IMainPageViewModel, MainPageViewModel>();
            container.Register<IFoodScheduleViewModel, FoodScheduleViewModel>();
        }
    }
}