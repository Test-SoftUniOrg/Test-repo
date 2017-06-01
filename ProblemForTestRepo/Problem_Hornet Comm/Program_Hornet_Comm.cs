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
            separateTransmisions(transmisionsArr, ref broadcasts, ref messages);
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

        public static void separateTransmisions(string[,] transmisionArr, ref List<string> broadcasts, ref List<string> messages)
        {
            
            foreach (var transmision in )
            {
                try 
                    {
                        var test = long.Parse(transmision[0]);
                    }

            }

        }

    }
}