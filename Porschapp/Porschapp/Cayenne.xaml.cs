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
    public partial class Cayenne : ContentPage
    {
        public Cayenne()
        {
            InitializeComponent();
            
            DescriptionOneCar.Text = "El Porsche Cayenne es un Automóvil todo terreno lanzado en 2002. " +
                                     "Es el primer vehículo de la marca que no entra dentro de la categoría de deportivos. Perteneciente al segmento E y con una potencia de 240CV," +
                                     " se convierte en el primer vehículo familiar de la marca y el primero en introducir una versión hibrida ";
            
            
            DescriptionOneCar.TextColor = Color.White;
            
           
            DescriptionTwoCar.Text = "Su primera generación contaba en su línea con modelos S y Turbo. " +
                                     "La Cayenne aunque criticada por los mas puristas de la marca fue la responsable de mantener a flote las ventas de la marca y evitar de esa forma la quiebra. " +
                                     "La entrada de este modelo en la línea de productos le dio el respiro necesario para culminar el desarrollo del Carrera GT.";


            DescriptionThreeCar.Text = "En el año 2011 se presenta la segunda generación del modelo. Con una figura mas estética basada en el Carrera GT, el icono de la marca por esos años. " +
                                       "En 2014 esta generación incorpora por primera vez un motor eléctrico lo que le transforma en el primer automóvil Porsche en ser hibrido. ";

            DescriptionFourCar.Text = "2018 se presenta la ultima generación de la Porsche Cayenne que comparte su cada vez mas sus bases con los Audi Q7 y Q8, Lamborghini Urus y Volkswagen Toureg. " +
                                      "Lo que marca la cada vez mas creciente influencia de Volkswagen sobre la marca, donde Porsche queda como su marca para el desarrollo tecnológico de punta. ";
        }
    }
}