using FoodPlanning.Features.MainPage;
using Xamarin.Forms;
using XLabs.Ioc;

namespace FoodPlanning.App
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();

            var vm = Resolver.Resolve<IMainPageViewModel>();

            this.BindingContext = vm;
        }
    }
}