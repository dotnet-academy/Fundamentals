using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class ListSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("List");
            
            var myList = new List<int>();

            // add elements into list
            myList.Add(3);
            myList.Add(4);
            myList.Add(1);
            myList.Add(2);

            Console.Write("The elements of the list as they were inserted: ");
            PrintListElements(myList);
            
            // sort the list
            myList.Sort();

            Console.Write("The List is now sorted: ");
            PrintListElements(myList);

            // reverse the list
            myList.Reverse();

            Console.Write("The list is now reversed: ");
            PrintListElements(myList);

            // count the items of the list
            Console.WriteLine($"The list contains {myList.Count} elements");

            Helpers.DisplaySectionEnd();
        }

        static void PrintListElements(List<int> input)
        {
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}

