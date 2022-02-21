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
    public partial class Porsche911 : ContentPage
    {
        public Porsche911()
        {
            InitializeComponent();
            //Descripcion del porsche 911 en general
            DescriptionOne.Text = "El Porsche 911 es un automóvil deportivo de lujo producido por el fabricante alemán Porsche AG, desde 1964. \n";
            DescriptionOne.Text += "\n Existen ocho generaciones que fueron puestas a la venta en los años " +
                                   "1964, 1974, 1988, 1993, 1998, 2004, 2011 y 2018; " +
                                   "y que se distinguen por su código de proyecto: 901, 930, 964, 993, 996, 997, 991 y 992.";
            
            DescriptionOne.TextColor = Color.White;
            
            //Porsche 911 901 general description
            DescriptionTwo.Text = "El Porsche 911 901 nació como el sucesor directo del mítico Porsche 356, ganador de la panamericana. " +
                                  "Con su tracción trasera y motor posterior de 140CV, el 911 daría inicio " +
                                  "a una saga de deportivos que se mantiene activa hasta nuestros días.  ";
            
            //Porsche 911 964 general description
            DescriptionThree.Text = "En 1988 se presento a la tercera entrega del modelo. El 964 fue el primero de los 911 en incorporar la tracción integral que " +
                                    "entrega el torque en las 4 ruedas del vehículo. " +
                                    "Este modelo contaba con un Motor bóxer 6 cilindros de 250CV. ";

            DescriptionFour.Text = "2004, nacimiento del nuevo Porsche 911." +
                                   " Fiel a la tradición, el 911 cuenta con un motor Bóxer 6 cilindros que en esta ocasión entrega en su versión base 325CV hasta un máximo de 620." +
                                   " En esta generación nació la caja de cambios automática PDK de doble embrague. ";

        }
    }
}