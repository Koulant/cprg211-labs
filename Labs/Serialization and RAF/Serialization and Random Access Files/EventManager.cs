using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_Serialization_and_Random_Access_Files
{
    internal class EventManager
    {
        private const string textFile = "events.txt";
        //private const string binaryFile = "events.bin";

        public List<Event> listOfEvents = new List<Event>();


        public void LoadListOfEventsFromTextFile()
        {
            using (StreamReader textReader = new StreamReader(textFile))
            {
                while (!textReader.EndOfStream)
                {
                    string line = textReader.ReadLine();
                    string[] fields = line.Split('_');

                    Event events = new Event(int.Parse(fields[0]), fields[1], fields[2])
                    {
                        EventNumber = int.Parse(fields[0]),
                        EventName = fields[1],
                        EventLocation = fields[2]
                    };
                    listOfEvents.Add(events);
                }
            }
        }

        public void AddEvent()
        {
            Event newEvent = new Event(6, "Hackathon", "Calgary");
            listOfEvents.Add(newEvent);
        }

        public void SaveListOfEventsToBinaryFile()
        {
            using (FileStream fileStream = new FileStream("events.bin", FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, listOfEvents);
            }
            
        }

        public void PrintFirstEventFromBinaryFile()
        {
            using (FileStream fileStream = new FileStream("events.bin", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                List<Event> events = (List<Event>)binaryFormatter.Deserialize(fileStream);

                Event firstEvent = events[0];
                Console.WriteLine($"EventNumber: {firstEvent.EventNumber}\nEventName: {firstEvent.EventName}\nEventLocation: {firstEvent.EventLocation}");
            }
        }

        public List<string> ReadLocationsFromFile()
        {
            List<string> listOfLocations = new List<string>();

            using (FileStream fileStream = new FileStream("events.bin", FileMode.Open))
            {
                foreach (Event e in listOfEvents)
                {
                    fileStream.Seek(16, SeekOrigin.Current); //skip event and name number bytes
                    byte[] locationBytes = new byte[e.EventLocation.Length];
                    fileStream.Read(locationBytes, 0, locationBytes.Length);
                    listOfLocations.Add(System.Text.Encoding.UTF8.GetString(locationBytes));
                }
                fileStream.Close();
  
                return listOfLocations;
            }
        }

        
    }
}
