using EventMaker.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Windows.Storage;

namespace EventMaker.Persistency
{
    class PersistencyService
    {
        StorageFolder localfolder = null;
        static private readonly string filnavnTilføjEvents = "Events.json";

        public PersistencyService()
        {
            localfolder = ApplicationData.Current.LocalFolder;
        }        

        public static async void SaveEventAsJsonAsync(ObservableCollection<Event> events)
        {
            string jsonText = JsonConvert.SerializeObject(events);
            SerializeEventsFileAsync(jsonText, filnavnTilføjEvents);
        }
        public static async Task<List<Event>> LoadEventsFromJsonAsync()
        {
            Model.EventCatalogSingleton.Instance.ObservableCollectionEvent.Clear();

            Task<string> jsonTaskText = DeSerializeEventsFileAsync(filnavnTilføjEvents);

            List<Event> newList = JsonConvert.DeserializeObject<List<Event>>(jsonTaskText.ToString());
               
        }

        private static async void SerializeEventsFileAsync(string eventsString, string filenavnTilføjEvents)
        {
            StorageFile file = await localfolder.CreateFileAsync(filenavnTilføjEvents, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, eventsString);
        }

        //private static async Task<string> DeSerializeEventsFileAsync(string filenavnTilføjEvents)
        {
        }


    }
}
