using Capacity.View.User;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Capacity
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            OnResume();
        }

        DisplayOrientation currentOrientation = DisplayOrientation.Unknown;
        void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            if (DeviceInfo.DeviceType == DeviceType.Virtual)
            {
                Task.Delay(500).ContinueWith((t) =>
                {
                    SetSpans(DeviceDisplay.MainDisplayInfo);
                }
                , TaskScheduler.FromCurrentSynchronizationContext());
                return;
            }

            SetSpans(e.DisplayInfo);
        }

        public static event EventHandler<EventArgs> SpanChanged;

        void SetSpans(DisplayInfo info)
        {
            if (currentOrientation == info.Orientation)
                return;

            currentOrientation = info.Orientation;

            var dp = info.Width / info.Density;
            SpanChanged?.Invoke(null, EventArgs.Empty);
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            DeviceDisplay.MainDisplayInfoChanged -= DeviceDisplay_MainDisplayInfoChanged;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;
            SetSpans(DeviceDisplay.MainDisplayInfo);
        }
    }
}
