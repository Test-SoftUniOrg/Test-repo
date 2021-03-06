﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_Hornet_Comm
{
    class Program_Hornet_Comm
    {
        static void Main()
        {
            var allTransmitions = new List<string>();
            string transmition = "";
            while (transmition != "Hornet is Green")
            {
                transmition = Console.ReadLine();
                if (transmition == "Hornet is Green")
                {
                    continue;
                }
                allTransmitions.Add(transmition);
            }

            var broadcasts = new List<string>();
            var messages = new List<string>();

            //? tuk dvumeren masiv li deklarira6 qvno string[,] i string[][] e edno i sy6to?
            string[,] transmisionsArr = ConvertToArray(allTransmitions);
            TestTransmisionsAndSeparateThem(transmisionsArr, ref broadcasts, ref messages);
        }
        //? ref? nikakva ideq nqmam kakvo e i kak i za6to se polzva?
        public static void TestTransmisionsAndSeparateThem(string[,] transmisionsArr, ref List<string> broadcasts, ref List<string> messages)
        {
            for (int i = 0; i < transmisionsArr.Length; i++)
            {
                try
                {
                    // Tests if the transmision is valid message.
                    var firstTestPart = long.Parse(transmisionsArr[0, i]);
                    if (TestForLettersAndDigits(transmisionsArr[1, i]))
                    {
                        messages.Add(transmisionsArr[0, i].Reverse() + " -> " + transmisionsArr[1, i]);
                    }
                }
                catch (FormatException)
                {
                    // Testing if first part has no digits.
                    if (testForNoDigits(transmisionsArr[0, i]) && (TestForLettersAndDigits(transmisionsArr[1, i])))
                    {
                        // this is valid broadcast.

                    }

                }
            }
        }

        public static string InvertCase(string text)
        {
            var charArr = text.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if ((charArr[i] >= 'a' && charArr[i] <= 'z'))
                {
                    var curientChar = charArr[i];
                    curientChar = (char)(curientChar - 'a' + 'A');
                    charArr[i] = curientChar;
                }
                if ((charArr[i] >= 'A' && charArr[i] <= 'Z'))
                {
                    var curientChar = charArr[i];
                    curientChar = (char)(curientChar - 'A' + 'a');
                    charArr[i] = curientChar;
                }
            }

            return charArr.ToString();
        }


        public static bool testForNoDigits(string text)
        {
            var result = true;
            foreach (char letter in text)
            {
                if ((letter >= '0') && (letter <= '9'))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static bool TestForLettersAndDigits(string text)
        {
            var result = true;
            foreach (char letter in text)
            {
                if (!(((letter >= '0') && (letter <= '9'))
                        || ((letter >= 'a') && (letter <= 'z'))
                        || ((letter >= 'A') && (letter <= 'Z'))))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static string[,] ConvertToArray(List<string> allTransmitions)
        {
            string[,] transmisionsArr = new string[2, allTransmitions.Count];
            for (int i = 0; i < transmisionsArr.Length; i++)
            {
                var splitedTransmision = allTransmitions[i].Split(' ');
                transmisionsArr[0, i] = splitedTransmision[0];
                transmisionsArr[1, i] = splitedTransmision[2];

            }

            return transmisionsArr;
        }



    }
}