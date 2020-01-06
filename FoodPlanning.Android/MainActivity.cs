using Android.App;
using Android.Content.PM;
using Android.OS;
using ZXing.Net.Mobile.Forms.Android;

namespace FoodPlanning.Android
{
    [Activity(Theme = "@style/MainTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            var bootstrapper = new AppBootstrapper();
            bootstrapper.SetupApplication();

            base.OnCreate(savedInstanceState);
            
            Platform.Init();
            
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App.App());
        }
    }
}