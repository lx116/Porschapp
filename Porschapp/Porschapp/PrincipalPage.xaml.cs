using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Porschapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : ContentPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }

        private void go_to_history(object sender, EventArgs e )
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new History());
            App.FlyoutP.IsPresented = false;
        }
        private void go_to_motorsport(object sender, EventArgs e )
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new MotorSport());
            App.FlyoutP.IsPresented = false;
        }
        private void go_to_models(object sender, EventArgs e )
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new AllModels());
            App.FlyoutP.IsPresented = false;
        }
    }
}