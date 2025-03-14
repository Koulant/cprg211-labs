using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    public class Relation
    {
        //Attributes
        enum RelationshipType
        {
            Sisterhood,
            Brotherhood,
            Motherhood,
            Fatherhood
        }

        public string Relationship;

        //Constructor
        public Relation(string relationship)
        {
            Relationship = relationship;
        }

        //Method

        public void ShowRelationship(Person person1, Person person2)
        {
            switch (Relationship)
            {
                case "S":
                    Console.WriteLine("Relationship between " + person1.FirstName + " and " + person2.FirstName + " is: " + RelationshipType.Sisterhood);
                    break;

                case "B":
                    Console.WriteLine("Relationship between " + person1.FirstName + " and " + person2.FirstName + " is: " + RelationshipType.Brotherhood);
                    break;
            }
        }


        // Office hours notes: 
        // Create a constructor to relate the two persons, then sets the relationship between the two people
        // The third relationship object will determine the relationship between the two people (connect both together)
        // Note: Default construcor will not take two parameters 
        // Think of all these as objects! 
        // public void ShowRelatlionship(Person p1, Person p2) 
        // swtich (RelatonshipType) 
        //case (similar to if else etc.) to check the case and then have the console.writeline p1.Firstname + ...

        // You could also make relation a method within the class Person

        // Can even make it a relation class with a list with two person objects, then relate them (most robust method) 
    }
}
