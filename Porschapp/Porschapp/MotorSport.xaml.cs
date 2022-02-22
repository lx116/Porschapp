using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Porschapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MotorSport : ContentPage
    {
        public class EventsInformation
        {
            public ImageSource _Events { get; set; }
            
            public String _Tittle_event { get; set; }
            public String _InfoEvent { get; set; }
        }

        private ObservableCollection<EventsInformation> eventsCollection;

        public ObservableCollection<EventsInformation> EventsInformations
        {
            get { return eventsCollection;}
            set
            {
                eventsCollection = value;
                OnPropertyChanged();
            }
        }
        public MotorSport()
        {
            InitializeComponent();
            BindingContext = this;
            EventsInformations = new ObservableCollection<EventsInformation>
            {
                new EventsInformation { _Events = "https://i.ibb.co/dJw4zWg/Porsche1982-Le-Mans.jpghttps://i.ibb.co/6yMfVjg/porsche-917-kh-le-mans-1970-f.jpg", 
                    _Tittle_event = "Primera victoria en Le Mans", _InfoEvent = "Porsche y las 24 horas de Le Mans son una historia bastante emocionante y aunque " +
                        "la firma alemana ha competido allí desde 1951, le tomo casi dos décadas lograr la tan anhelada victoria general, algo que se " +
                        "logró cuando inició el desarrollo de modelos más" +
                        " rápidos y tecnológicos, culminando con el legendario Porsche 917 a finales de los años 60."
                    
                },
                new EventsInformation { _Events = "https://i.ibb.co/WV76rpN/733850eefc59e2250b4dd82a23f88c33.jpg", 
                    _Tittle_event = "Carrera panamericana", _InfoEvent = "Los años 50 fueron una época importante en la historia de Porsche, su papel en la " +
                                                                         "competiciones automovilísticas como la Carrera Panamericana.  " +
                                                                         "El modelo 356 participó en la Panamericana, el primero en salir de los talleres de Porsche con y bajo la destreza."
                    
                },
                
            };
        }
    }
}