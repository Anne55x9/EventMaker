using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using EventMaker.Model;
using Newtonsoft.Json;

namespace EventMaker.Model
{
   public class EventCatalogSingleton
    {
        
        private static EventCatalogSingleton instance;

        private EventCatalogSingleton()
        {
            ObservableCollectionEvent.Add(new Event(1, "event1", "description1", "place1", new DateTime(1423, 12, 2)));
            ObservableCollectionEvent.Add(new Event(3, "event3", "description3", "place3", new DateTime(1438, 12, 2)));
            
        }


        private void AddEvent(Event EV)
        {
            ObservableCollectionEvent.Add(EV);
            Persistency.PersistencyService.SaveEventAsJsonAsync(ObservableCollectionEvent);
        }

      public void RemoveEvent(Event SelectedEvent)
        {
            ObservableCollectionEvent.Remove(SelectedEvent);
        }


        public ObservableCollection<Event> ObservableCollectionEvent { get; set; }
        public static EventCatalogSingleton Instance
        {


            get
            {
                if (instance == null)
                {
                    instance = new EventCatalogSingleton();
                }
                return instance;
            }
        }

        }
}


