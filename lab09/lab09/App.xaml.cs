using lab09.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab09
{
    public partial class App : Application
    {

        public static float ScreenHeight { get; set; }
        public static float ScreenWidth { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new SwipeDemo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
