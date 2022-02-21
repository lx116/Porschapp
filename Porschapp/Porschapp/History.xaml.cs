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

            Intro.Text = "\nLa leyenda nos remonta a 1948 cuando un joven hijo de ingeniero salió " +
                         "en busca del automóvil perfecto y el fracaso que conllevo en ese " +
                         "intento le permitiría a la industria del automóvil el nacimiento de una de sus marcas mas legendarias. ";

            Europa.Text = "En 1948, Europa estaba pasando grandes apuros y la demanda del mercado era para automóviles prácticos y asequibles. " +
                          "En esta situación, Ferry Porsche decidió cumplir su sueño de crear su propio deportivo";
            
            P356.Text = "El Porsche 356, montaba una motorización de cuatro cilindros opuestos, una nueva caja de cambios, suspensión, muelles y dirección de origen Volkswagen. " +
                        "Con un peso de tan sólo 585 kg, " +
                        "este roadster de motor central con 35 CV desarrollaba una velocidad máxima de 135 km/h";

            P901.Text = "En 1964 es introducido el 911. ";
            P901.Text +=
                "El prototipo fue denominado «Porsche 901», pero una demanda de Peugeot llevó a que el nombre comercial se cambiara a 911, " +
                "el mismo número de emergencias en Estados Unidos, con lo que su fama comenzó a incrementarse notablemente.";

            Crisis.Text = "En 1980 Porsche se encontraba en un punto critico, las ventas de sus carros estaban resentidas. De los 50mil vehículos que " +
                          "vendían antes de entrada la década de los 80; fueron reducidos a menos de la mitad para entrados los 80 y" +
                          " llegando a punto critico de solo vender 6mil vehículos durante el 91";
            
            Presente.Text = "En 2002 llega la resurrección de la marca, con la llegada de Cayenne y la inauguración de la fabrica de Leipzig el " +
                            "panorama comenzaba a mejorar. Las ventas de Cayenne eran de unas 30mil unidades anuales, " +
                            "lo cual representaba un respiro para la marca que posteriormente pasaría a manos del grupo automotriz Volkswagen.  ";
        }
    }
}