using System;
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

            string[,] transmisionsArr = convertToArray(allTransmitions);
            TestTransmisionsAndSeparateThem(transmisionsArr, ref broadcasts, ref messages);
        }

        public static void TestTransmisionsAndSeparateThem(string[,] transmisionsArr, ref List<string> broadcasts, ref List<string> messages)
        {
            for (int i = 0; i < transmisionsArr.Length; i++)
            {
                try
                {
                    // Tests if the transmision is valid message.
                    var firstTestPart = long.Parse(transmisionsArr[0, i]);
                    if (testForLettersAndDigits(transmisionsArr[1, i]))
                    {
                        messages.Add(transmisionsArr[0, i].Reverse() + " -> " + transmisionsArr[1, i]);
                    }
                }
                catch (FormatException)
                {
                    // Testing if first part has no digits.
                    if (testForNoDigits(transmisionsArr[0, i]) && (testForLettersAndDigits(transmisionsArr[1, i])))
                    {
                        // this is valid broadcast.

                    }

                }
            }
        }

<<<<<<< HEAD
=======
        public static string InvertCase(string text)
        {
            var charArr = text.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if ((charArr[i] >= 'a' && charArr[i] <= 'z'))
                {
                    var curientChar = charArr[i];
                    curientChar = (char)(curientChar - 'a');
                    curientChar += 'A';
                    charArr[i] = curientChar;
                }
                else if ((charArr[i] >= 'A' && charArr[i] <= 'Z'))
                {
                    var curientChar = charArr[i];
                    curientChar = (char)(curientChar - 'A');
                    curientChar += 'a';
                    charArr[i] = curientChar;
                }
            }

            return charArr.ToString();
        }

>>>>>>> f91c2656560f9daec1693241cf575eb219e9d857
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

        public static bool testForLettersAndDigits(string text)
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

        public static string[,] convertToArray(List<string> allTransmitions)
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