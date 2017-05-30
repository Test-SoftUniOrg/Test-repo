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
                allTransmitions.Add(Console.ReadLine());
            }

            var transmitionsArray = new string[2, allTransmitions.Count];
            for (int i = 0; i < transmitionsArray.Length; i++)
            {
                var transmisionParts = allTransmitions[i].Split(' ');
                transmitionsArray[0, i] = transmisionParts[0];
                transmitionsArray[1, i] = transmisionParts[2];
            }
<<<<<<< HEAD
=======
			
			for (int i = 0; i < transmitionsArray.Length; i++)
            {
                
                Console.WriteLine(transmitionsArray[0, i]);
                Console.WriteLine(transmitionsArray[1, i]);
            }

>>>>>>> 9d7cac6bbe354f19ef870c27f69cd21d5e14895f

        }
    }
}
