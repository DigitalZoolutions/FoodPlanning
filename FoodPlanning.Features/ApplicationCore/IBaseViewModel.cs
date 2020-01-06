using System.ComponentModel;

namespace FoodPlanning.Features.ApplicationCore
{
    public interface IBaseViewModel : INotifyPropertyChanged
    {
        string ErrorMessage { get; set; }
        bool HasError { get; }
        bool IsBusy { get; set; }
    }
}