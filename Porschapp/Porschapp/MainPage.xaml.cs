using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Porschapp
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Flyout = new PrincipalPage();
            this.Detail = new NavigationPage(new DetailPage())
            {
                BarBackgroundColor = Color.FromHex("#222831"),
                BarTextColor = Color.White
            };
            App.FlyoutP = this;
        }
    }
}