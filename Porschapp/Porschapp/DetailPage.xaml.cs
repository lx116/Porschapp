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
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
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

        private void go_to_911(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new Porsche911());
            App.FlyoutP.IsPresented = false;
        }
        private void go_to_carrera(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new Carrera());
            App.FlyoutP.IsPresented = false;
        }
    }
}