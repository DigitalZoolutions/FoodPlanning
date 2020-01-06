using FoodPlanning.App.AppCore;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace FoodPlanning.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            foreach (var mappedRoute in AppSettings.RoutingDictionary)
            {
                Routing.RegisterRoute(mappedRoute.Route, mappedRoute.PageType);
            }

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=dfa5eaff-92ed-4e19-95b5-968c4552c9e1;" +
                            "uwp=6e2c818f-730c-4d59-a5ff-63de48f99bee;" +
                            "ios=984e03af-7eb8-4742-9247-22f39fccfbab;",
                typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}