using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.Marcomaldonado.Sunmiv2.Services;
//using AndroidJavaBinding;

namespace PruebaMauiJavaBinding;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected async override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        SunmiPrinter.Instance.InitPrinter(ApplicationContext);

    }
}
