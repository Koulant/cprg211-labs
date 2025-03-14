using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lab: Creating Classes

namespace CreatingClasses
{
    //Creating a Person class
    public class Person
    {
        //Attributes
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }

        //Constructors
        //Set the initial values for class Person
        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColor = favoriteColor;
            Age = age;
            IsWorking = isWorking;
        }

        //Set favortie color
        public Person(string favoriteColor)
        {
            FavoriteColor = favoriteColor;
        }

        //Get age in 10 years
        public Person(int age)
        {
            Age = age + 10;
        }

        //Methods 
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{PersonId}: {FirstName} {LastName}'s favorite color is {FavoriteColor}.");
        }

        public void ChangeFavoriteColour()
        {
            FavoriteColor = "White";
            DisplayPersonInfo();
        }

        public void GetAgeInTenYears()
        {
            Age = Age + 10;
            Console.WriteLine(Age);
        }

        public override string ToString()
        {
            return $"PersonId: {PersonId} \n" +
                $"FirstName: {FirstName} \n" +
                $"LastName: {LastName} \n" +
                $"FavoriteColor: {FavoriteColor} \n" +
                $"Age: {Age} \n" +
                $"IsWorking; {IsWorking}";
        }
    }
}
