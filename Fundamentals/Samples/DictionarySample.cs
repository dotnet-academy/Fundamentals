using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class DictionarySample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Dictionary");
            
            var myDictionary = new Dictionary<int, string>();

            // add elements into dictionary
            myDictionary.Add(1, "John");
            myDictionary.Add(2, "George");
            myDictionary.Add(3, "Mike");
            PrintDictionaryItems(myDictionary);

            // below code will throw exception because key with value 1 already exists
            //myDictionary.Add(1, "Tom");

            bool success;
            success = myDictionary.TryAdd(1, "Tom"); // success will be false, but no exception thrown

            // get elements value from dictionary
            success = myDictionary.TryGetValue(1, out var dicValue); // success will be true and value will be stored in out variable

            if (success)
            {
                Console.WriteLine($"Item with key=1 has value={dicValue}");
            }


            Helpers.DisplaySectionEnd();
        }

        static void PrintDictionaryItems(Dictionary<int, string> myDictionary)
        {
            foreach(var item in myDictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}

