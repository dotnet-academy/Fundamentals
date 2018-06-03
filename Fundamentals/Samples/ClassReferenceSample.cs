using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class ClassReferenceSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Class Reference");

            var count = 3;

            // Wrong way, all list elements refer to the same instance
            // resulting to ending up with the last values assigned to the instance
            {
                Console.WriteLine("Wrong way, all list elements refer to the same instance");

                var persons = new List<Person>();
                var person = new Person();

                for (int i = 0; i < count; i++)
                {
                    person.Age = i;
                    person.FirstName = "First" + i;
                    person.LastName = "Last" + i;

                    persons.Add(person);
                }

                PrintListElements(persons);
            }

            // Correct way, each list element refers to different instance
            {
                Console.WriteLine("Correct way, each list element refers to different instance");

                var persons = new List<Person>();

                for (int i = 0; i < count; i++)
                {
                    var person = new Person()
                    {
                        Age = i,
                        FirstName = "First" + i,
                        LastName = "Last" + i
                    };

                    persons.Add(person);
                }

                PrintListElements(persons);
            }

            Helpers.DisplaySectionEnd();
        }

        static void PrintListElements(List<Person> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Age);

                Console.WriteLine();
            }
        }

        public class Person
        {
            public int Age { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }
        }

    }
}

