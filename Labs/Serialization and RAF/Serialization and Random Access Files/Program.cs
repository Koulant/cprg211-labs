using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Serialization_and_Random_Access_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            eventManager.LoadListOfEventsFromTextFile();
            eventManager.AddEvent();
            eventManager.SaveListOfEventsToBinaryFile();
            eventManager.PrintFirstEventFromBinaryFile();
            List<string> listOflocations = eventManager.ReadLocationsFromFile();
            Console.WriteLine("Locations of the events from event.bin filled into a list of strings.", listOflocations);
            Console.ReadKey();
        }
    }
}
