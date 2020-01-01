using System;

namespace FoodPlanning.Common.ApplicationCore
{
    public class NavigationRouteItem
    {
        public string Route { get; set; }
        public Type ViewModel { get; set; }
        public Type PageType { get; set; }

        public NavigationRouteItem(string route, Type viewModel, Type pageType)
        {
            Route = route;
            ViewModel = viewModel;
            PageType = pageType;
        }
    }
}