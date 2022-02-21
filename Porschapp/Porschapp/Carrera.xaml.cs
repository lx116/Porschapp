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
    public partial class Carrera : ContentPage
    {
        public Carrera()
        {
            InitializeComponent();
            //Descripcion del porsche 911 en general
            DescriptionOneCar.Text = "El Porsche Carrera GT es un Superdeportivo del fabricante Porsche producido entre 2003 y 2006. " +
                                  "Galardonado como el carro mas rápido de 2005 el Porsche Carrera GT cuenta con un motor central trasero que genera 612CV " +
                                  "dirigidos a las ruedas traseras. ";
            
            
            DescriptionOneCar.TextColor = Color.White;
            
            //Porsche 911 901 general description
            DescriptionTwoCar.Text =
                "El Carrera GT esta basado en los modelos 911 GT1 ’98 y el LMP1-98 que no lograron pasar el reglamento de la FIA. " +
                "Inicialmente el Carrera GT tendría un motor de 6 cilindros en línea turbo cargado, " +
                "pero la mala situación económica de Porsche retraso su desarrollo hasta el año 2000.";
            
            //Porsche 911 964 general description
            DescriptionThreeCar.Text = "El Carrera GT obtuvo su motor de V10 Atmosférico de 5,5 litros proveniente de un motor de Le Mans que llevaba siendo " +
                                    "desarrollado en secreto desde 1992. El Carrera GT es de los pocos carros que en su " +
                                    "versión de producción logra superar en potencia a su versión prototipo; contando así con un motor 5,7 litros y 612CV. ";

            DescriptionFourCar.Text =
                "De esta forma logro convertirse en uno de los hitos mas grandes de la marca. Una obra de la " +
                "ingeniería que goza por ser el ultimo vehículo 100% análogo de la marca. Una obra de arte para las calles. ";
        }
    }
}