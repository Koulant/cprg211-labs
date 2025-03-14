using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingClasses;

//Unit 1: Learning Activities 
//Lab: Creating Classes
//Author: Anton Koulikov

namespace CreatingClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Person objects
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //Calling Class Methods
            //Display Gina’s information as a sentance
            person2.DisplayPersonInfo();

            //Display all of Mike’s information as a list.
            Console.WriteLine(person3.ToString());

            //Change Ian’s Favorite Colour to white then print his information as a sentence
            person1.ChangeFavoriteColour();

            //Display Mary’s age after ten years
            person4.GetAgeInTenYears();

            //Create two Relation Objects that show that Gina & Mary are sisters and that Ian & Mike are brothers
            //Relation objects
            Relation Sisters = new Relation("S");
            Relation Brothers = new Relation("B");

            //Display both relationships
            Sisters.ShowRelationship(person2, person4);
            Brothers.ShowRelationship(person1, person3);


            /* Add all the Person objects to a list then use the list to display the following
            The average age of the people in the list
            The youngest person and the oldest person
            The names of the people whose first names start with M
            The person information of the person that likes the colour blue
            */

            //Ran out of time to complete the rest of the code :( 
            //Will work hard to get started earlier to prevent this problem in the future :) 

            // Keeps program running until a key is pressed
            Console.ReadKey(true);
        }
    }
}
