using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3_1
{

    static class Programm
    {
        static void Main()
        {
            List<string> firstList = new List<string>()
            {
                "first",
                "second",
                "third",
                "fourth",
                "fift"
            };

            List<string> secondList = new List<string>();
            secondList.Add("first");
            for (int i = 1; i < firstList.Count; i++)
            {
                string textToAdd = firstList[i];
                textToAdd += " " + secondList[i - 1];
                secondList.Add(textToAdd);
            }

            foreach (string textToOutput in secondList)
            {
                Console.WriteLine(textToOutput);
            }
        }
    }
}