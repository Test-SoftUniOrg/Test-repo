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

            while (true)
            {
                var transmition = Console.ReadLine();
                if (transmition == "Hornet is Green") break;
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

                };
            }
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