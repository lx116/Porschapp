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
    public partial class Tycan : ContentPage
    {
        public Tycan()
        {
            InitializeComponent();


            DescriptionOneCar.Text = "El Porsche Taycan es un golpe de efecto dentro de la industria. Esta marca el primer paso de la hacia la electrificación y es la bandera para el futuro eléctrico de Volkswagen al lado de los Audi E-Tron. " +
                                     "Fue lanzado en 2019 y ya representa un 7.4% de las ventas totales dentro de la línea de vehículos de Porsche. ";
            
            
            DescriptionOneCar.TextColor = Color.White;


            DescriptionTwoCar.Text = "El Taycan parte del concepto Porsche Mission E revelado en Frankfurt Motor Show 2015. " +
                                     "Impulsado por dos motores sincrónicos que están ubicados uno en cada eje y generan una potencia de 440KW que se traducen a unos 590CV y su 0-100 figura en los 3.5 segundos. ";


            DescriptionThreeCar.Text = "El modelo de producción cuenta con dos motores eléctricos sincrónicos que generan desde 402CV hasta 751CV de la versión turbo S. " +
                                       "Los motores se encuentran cada uno ubicado en un eje. Cuenta con una duración de batería de 400KM";

            DescriptionFourCar.Text = "Este es un paso importante para la marca y se espera que pronto se incorporen nuevos productos para acompañar el nuevo futuro eléctrico de la marca. " +
                                      "Porsche es dueña de una gran parte de Rimac Automobili la cual proporcionara la tecnología del futuro eléctrico y llevara a un gran futuro a ambas marcas.  ";
        }
    }
}