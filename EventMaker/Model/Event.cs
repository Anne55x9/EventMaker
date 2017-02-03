using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Converter;
using EventMaker;

namespace EventMaker.Model
{
    class Event
    {
      public  int Id;
       public string Names;
        public string Description;
       public string Place;
       public DateTime DateTime;

        public Event(int Id, String Names, string Description, string Place, DateTime DateTime)
        {
            this.Id = Id;
            this.Names = Names;
            this.Description = Description;
            this.Place = Place;
            this.DateTime = DateTime;
        }

      

        public override string ToString()
        {
            return base.ToString();
        }


  
    }
}
