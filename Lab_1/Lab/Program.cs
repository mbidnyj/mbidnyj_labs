using System;
using System.Collections.Generic;

namespace MyProject
{
    static class Program
    {
        class Text
        {
            private List<string> text = new List<string> { "first", "second", "third" };
            private int length = 0;

            public void AddText(string str)
            {
                text.Add(str);
                length++;
            }
            public void InsertText(int index, string str)
            {
                text.Insert(index, str);
                length++;
            }
            public void RemoveText(string str)
            {
                text.Remove(str);
                length--;
            }
            public void ShowText()
            {
                foreach (string str in text)
                {
                    Console.WriteLine(str);
                }
            }
            public void ShowTextAtIndex(int index)
            {
                Console.Write(text[index]);
            }
            public void IsInText(string strToFind)
            {
                foreach (string str in text)
                {
                    if (strToFind == str)
                    {
                        Console.WriteLine("There is this string in text at index " + text.IndexOf(str));
                        return;
                    }
                }
                Console.WriteLine("There is no string " + strToFind + " in this text");
            }
            public void ShowTheLongestStr()
            {
                string theLongestStr = "";
                foreach (string str in text)
                {
                    if (str.Length > theLongestStr.Length)
                    {
                        theLongestStr = str;
                    }
                }
                Console.WriteLine(theLongestStr);
            }
            public void ShowTheShortestStr()
            {
                string theShortestSrt = "";
                foreach (string str in text)
                {
                    if (str.Length < theShortestSrt.Length)
                    {
                        theShortestSrt = str;
                    }
                }
                Console.WriteLine(theShortestSrt);
            }
            public void IsEqualTo(Text equalText)
            {
                if (equalText.length != this.length)
                {
                    Console.WriteLine("Texts are not equal");
                    return;
                }
                else
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (equalText.text[i] != this.text[i])
                        {
                            Console.WriteLine("Texts are not equal");
                            return;
                        }
                    }
                    Console.WriteLine("Texts are equal");
                    return;
                }

            }
        }
        static void Main()
        {
            Text text1 = new Text();
            /*text1.AddText("fourth");*/
            /*text1.InsertText(5, "fifth");*/
            /*text1.RemoveText("first");*/
            /*text1.ShowText();*/
            /*text1.ShowTextAtIndex(1);*/
            /*text1.IsInText("second");*/
            /*text1.ShowTheLongestStr();*/
            /*text1.ShowTheShortestStr();*/

            /*Text text2 = new Text();
            text2.IsEqualTo(text1);*/
        }
    }
}