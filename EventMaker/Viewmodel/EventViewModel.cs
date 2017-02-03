using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Model;

namespace EventMaker.Viewmodel
{
    class EventViewModel
    {
        public EventCatalogSingleton Singleton { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripition { get; set; }
        public string Place { get; set; }
        public DateTimeOffset Date { get; set; }
        public TimeSpan Time { get; set; }
        public EventViewModel()
        {
            DateTime dt = System.DateTime.Now;
            DateTimeOffset _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new
                TimeSpan());
            TimeSpan _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

        }
    }   
}
