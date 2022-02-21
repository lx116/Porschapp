using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("911porschav3.ttf", Alias = "Porsche")]
[assembly: ExportFont("Montserrat-VariableFont_wght.ttf", Alias = "Montserrat")]
namespace Porschapp
{
    public partial class App : Application
    {
        public static FlyoutPage FlyoutP { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}