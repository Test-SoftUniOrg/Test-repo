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

            for (int i = 0; i < transmitionsArray.Length; i++)
            {

                Console.WriteLine("{0} -> {1}", transmitionsArray[0, i], transmitionsArray[1, i]);
            }

        }
    }
}
