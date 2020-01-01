using System.Windows.Input;
using FoodPlanning.Common.ApplicationCore;
using Xamarin.Forms;
using XLabs.Ioc;

namespace FoodPlanning.Common.SignIn
{
    public class SignInViewModel : BaseViewModel, ISignInViewModel
    {
        private string username;
        private string password;

        public string Username
        {
            get => username;
            set
            {
                username = value;
                this.ErrorMessage = "";
                this.OnPropertyChanged(nameof(this.Username));
            }
        }

        public string Password
        {
            get => password;
            set
            {
                password = value;
                this.ErrorMessage = "";
                this.OnPropertyChanged(nameof(this.Password));
            }
        }

        public string SelectedHotel { get; set; }

        public ICommand SignIn { get; set; }
        public ICommand Register { get; set; }

        public SignInViewModel()
        {
            this.SignIn = new Command(SignInUser);
            this.Register = new Command(RegisterUser);
        }

        private async void SignInUser()
        {
            if (!EntriesAreValid())
                return;
            
            var app = Resolver.Resolve<IAppSettings>();
        }

        private async void RegisterUser()
        {
            if (!EntriesAreValid())
                return;
        }

        private bool EntriesAreValid()
        {
            if (string.IsNullOrEmpty(this.Username))
            {
                this.ErrorMessage = "Please enter a username";
                return false;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                this.ErrorMessage = "Please enter a password";
                return false;
            }

            return true;
        }
    }
}