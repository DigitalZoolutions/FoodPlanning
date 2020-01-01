using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodPlanning.Common.ApplicationCore;
using FoodPlanning.Common.MainPage;
using FoodPlanning.Common.SignIn;
using Xamarin.Forms;

namespace FoodPlanning.App.AppCore
{
    public class AppSettings : IAppSettings
    {
        public async Task OpenPage(Type viewModel, Dictionary<string, string> parameter = null, bool clearHistory = false)
        {
            var stringUri = RoutingDictionary.FirstOrDefault(i => i.ViewModel == viewModel)?.Route;

            if (stringUri == null)
                throw new Exception($"No view for {viewModel} found!");

            switch (stringUri)
            {
                case "signin":
                    Application.Current.MainPage = new NavigationPage(new SignInPage()){
                        BarBackgroundColor = Color.Black,
                        Title = "Food Planning"
                    };
                    break;
                case "mainpage":
                    Application.Current.MainPage = new MainPage();
                    break;
                default:
                    if (parameter != null)
                        stringUri = AddQueryToRouteUri(stringUri, parameter);
                    
                    await Shell.Current.GoToAsync(stringUri);
                    break;
            }
        }

        private static string AddQueryToRouteUri(string uri, Dictionary<string, string> queries)
        {
            if (queries.Count > 0)
                uri += "?";

            foreach (var index in Enumerable.Range(0, queries.Count))
            {
                uri += queries.Keys.ElementAt(index) + "=" + queries.Values.ElementAt(index);

                if (index != queries.Count - 1)
                    uri += "&";
            }

            return uri;
        }
        
        internal static readonly List<NavigationRouteItem> RoutingDictionary = new List<NavigationRouteItem>
        {
            new NavigationRouteItem ("signin", typeof(ISignInViewModel), typeof(SignInPage)),
            new NavigationRouteItem ("mainpage", typeof(IMainPageViewModel), typeof(MainPage)),
        };
    }
}