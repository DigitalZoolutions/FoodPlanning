using FoodPlanning.Features.FoodSchedule;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Ioc;

namespace FoodPlanning.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodSchedulePage : ContentPage
    {
        public FoodSchedulePage()
        {
            InitializeComponent();

            var vm = Resolver.Resolve<IFoodScheduleViewModel>();

            this.BindingContext = vm;
        }
    }
}