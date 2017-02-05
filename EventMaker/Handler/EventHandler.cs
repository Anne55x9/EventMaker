using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Viewmodel;
using EventMaker.Converter;
namespace EventMaker.Handler
{
    class EventHandler 

    {

        public EventViewModel refEventViewModel { get; set; }

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
    }
}