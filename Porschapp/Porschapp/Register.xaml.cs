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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Login(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new DetailPage());
            App.FlyoutP.IsPresented = false;
        }

    }
}