using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Model;
using EventMaker.Common;
using EventMaker.Handler;
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace EventMaker.Viewmodel
{
   public class EventViewModel: INotifyPropertyChanged
    {
        public EventCatalogSingleton Singleton { get; set; }
     public ObservableCollection<Event> _ObservableCollectionEvent { get { return EventCatalogSingleton.Instance.ObservableCollectionEvent; } }
       

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripition { get; set; }
        public string Place { get; set; }
        public DateTimeOffset Date { get; set; }
        public TimeSpan Time { get; set; }
        public Relaycommand CreateEventCommand { get; set; }
        public Relaycommand DeleteEventCommand { get; set; }
     public Model.Event selectedEvent;

        public Event SelectedEvent
        {
            get { return selectedEvent; }
            set
            {
                selectedEvent = value;
                OnPropertyChanged(nameof(SelectedEvent));
            }
        }

        private EventMaker.Handler.EventHandler eventHandler { get; set; }

        public EventViewModel()
        {
            DateTime dt = System.DateTime.Now;
            DateTimeOffset _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new
                TimeSpan());
            TimeSpan _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            CreateEventCommand = new Relaycommand(eventHandler.CreateEvent, null);
            DeleteEventCommand = new Relaycommand(eventHandler.RemoveEvent, EmptyCheck);
        }
        
        public bool EmptyCheck()
        {
            if (EventCatalogSingleton.Instance.ObservableCollectionEvent.Count() == 0)
            {
                return false;
            }
            
            else

            {
                return true;
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)

        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
