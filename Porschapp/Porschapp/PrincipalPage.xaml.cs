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

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new HomePage());
            App.FlyoutP.IsPresented = false;
        }
    }
}