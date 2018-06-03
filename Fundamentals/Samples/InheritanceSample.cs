using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class InheritanceSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Inheritance");

            var adam = new Person()
            {
                Age = 1,
                FirstName = "Adam",
                LastName = "Firstofhiskind"
            };

            Console.WriteLine(adam.Greet());
            Console.WriteLine(adam.GetFullName());
            Console.WriteLine(adam.Eat());

            // Adam is now older, a teenager
            var adamTeenager = new Teenager()
            {
                Age = 15,
                FirstName = "Adam",
                LastName = "Firstofhiskind"
            };

            // Adam as a teenager now. He still
            // communicates his full name and greets people
            Console.WriteLine(adamTeenager.Greet());
            Console.WriteLine(adamTeenager.GetFullName());
            // and likes junk food
            Console.WriteLine(adamTeenager.Eat());

            // but now he has to go to school
            adamTeenager.GoToShool();
            // and he rides motorbikes when his mom
            // is not looking.
            adamTeenager.RideMotorbikes();

            // Adam is a fully grown man now.
            var adamAdult = new Adult()
            {
                Age = 35,
                FirstName = "Adam",
                LastName = "Firstofhiskind",
                VatNumber = "123456789"
            };

            // He has an identification number for
            // paying his taxes
            Console.WriteLine(adamAdult.VatNumber);
            // whatever money he has left spends it in exotic cuisine
            Console.WriteLine(adamAdult.Eat());


            Helpers.DisplaySectionEnd();
        }
    }

    public class Person
    {
        public int Age { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public virtual string Greet()
        {
            return "Hello";
        }

        public virtual string Eat()
        {
            return "Food";
        }
    }

    /// <summary>
    /// A teenager is a Person with additional properties
    /// and interactions with the world
    /// </summary>
    public class Teenager : Person
    {
        public void GoToShool()
        {
            Console.WriteLine("Wake up early, get schoolbag, bla bla");
        }

        public void RideMotorbikes()
        {
            Console.WriteLine("yeehaa");
        }

        public override string Eat()
        {
            return "Burgers!";
        }
    }

    /// <summary>
    /// An adult is a Person with additional properties
    /// and interactions with the world
    /// </summary>
    public class Adult : Person
    {
        public string VatNumber { get; set; }

        public override string Greet()
        {
            return "Greetings sir/madame";
        }

        public override string Eat()
        {
            return "Sushi";
        }
    }
}

