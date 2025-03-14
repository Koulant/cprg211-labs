using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Serialization_and_Random_Access_Files
{
    [Serializable]
    public class Event
    {
        public int EventNumber { get; set; }
        public string EventName { get; set; }
        public string EventLocation { get; set; }

        
        public Event(int eventNumber, string eventName, string eventLocation)
        {
            EventNumber = eventNumber;
            EventName = eventName;
            EventLocation = eventLocation;
        }
        
    }
}
