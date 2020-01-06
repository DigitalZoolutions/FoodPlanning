using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FoodPlanning.Features.ApplicationCore
{
    public class BaseViewModel : IBaseViewModel
    {
        private string errorMessage;
        private bool hasError;
        private bool isBusy;

        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                this.HasError = !string.IsNullOrEmpty(value);
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public bool HasError
        {
            get => hasError;
            private set
            {
                hasError = value;
                OnPropertyChanged(nameof(HasError));
            }
        }

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}