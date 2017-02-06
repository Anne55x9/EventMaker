using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Viewmodel;
using EventMaker.Converter;
using EventMaker.Model;

namespace EventMaker.Handler
{
    class EventHandler 

    {

        public EventViewModel refEventViewModel { get; set; }
        public EventCatalogSingleton refEventCatalogSingleton { get; set; }

        public EventHandler(EventViewModel Evm)
        {
            this.refEventViewModel = Evm;
        

        }

     public void CreateEvent()
        {
            refEventViewModel.Singleton.ObservableCollectionEvent.Add
                (new Model.Event(refEventViewModel.Id, refEventViewModel.Name,
                refEventViewModel.Descripition, refEventViewModel.Place,
                DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime
                (refEventViewModel.Date, refEventViewModel.Time)));
        }
   
        public void RemoveEvent()
        {
          
        refEventCatalogSingleton.RemoveEvent(refEventViewModel.selectedEvent);
        }
    }
}