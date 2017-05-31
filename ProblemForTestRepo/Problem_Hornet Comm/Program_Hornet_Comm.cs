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

            var transmitionsArray = new string[2, allTransmitions.Count];
            for (int i = 0; i < transmitionsArray.Length; i++)
            {
                var transmisionParts = allTransmitions[i].Split(' ');
                transmitionsArray[0, i] = transmisionParts[0];
                transmitionsArray[1, i] = transmisionParts[2];
            }

            var broadcasts = new string[2,transmitionsArray.Length];
            broadcasts = separateBoradcasts(transmitionsArray);

            var messagesCount = transmitionsArray.Length - broadcasts.Length;
            var messages = new string[2, messagesCount];
            messages = separateMessages(transmitionsArray, messagesCount);

            for (int i = 0; i < transmitionsArray.Length; i++)
            {

                Console.WriteLine("{0} -> {1}", transmitionsArray[0, i], transmitionsArray[1, i]);
            }

        }



        public static string[,] separateBoradcasts(string[,] transmitionsArray)
        {
            var broadcasts = new string[2, transmitionsArray.Length];

            // добавяш само broadcast-овете
			// съжалявам, че не успявам да се включа активно

            return broadcasts;
        }
        
        public static string[,] separateMessages(string[,] transmitionsArray, int messagesCount)
        {
            var messages = new string[2, messagesCount];

            // зареждаш съобщенията в масива
			// много от нещата, които си направил не са ми ясни като код

            return messages;
        }
    }
}
