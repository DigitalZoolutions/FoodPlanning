using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodPlanning.Common.ApplicationCore
{
    public interface IAppSettings
    {
        Task OpenPage(Type viewModel, Dictionary<string, string> parameter, bool clearHistory);
    }
}