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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void Entry_OnCompleted(object sender, EventArgs e)
        {
            
        }
        private void Login(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new DetailPage());
            App.FlyoutP.IsPresented = false;
        }

        private void RegisterPage(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new Register());
            App.FlyoutP.IsPresented = false;
        }
        
    }
}