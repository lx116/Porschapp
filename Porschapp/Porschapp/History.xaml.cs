using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Porschapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class History : ContentPage
    {
        public History()
        {
            InitializeComponent();

            Intro.Text = "La leyenda nos remonta a 1948 cuando un joven hijo de ingeniero salió " +
                         "en busca del automóvil perfecto y el fracaso que conllevo en ese " +
                         "intento le permitiría a la industria del automóvil el nacimiento de una de sus marcas mas legendarias. ";
        }
    }
}