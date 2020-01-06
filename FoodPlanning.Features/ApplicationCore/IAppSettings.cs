using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodPlanning.Features.ApplicationCore
{
    public interface IAppSettings
    {
        Task OpenPage(Type viewModel, Dictionary<string, string> parameter, bool clearHistory);
    }
}