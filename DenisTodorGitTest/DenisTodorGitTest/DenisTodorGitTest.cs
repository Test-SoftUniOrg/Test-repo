using System;

namespace DenisTodorGitTest
{
    class DenisTodorGitTest
    {
        static void Main(string[] args)
        {
            // upper half

            int dressSize = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', dressSize), new string('*', dressSize));
            int sides = dressSize;
            for (int i = 0; i < dressSize / 2; i++)
            {
                sides -= 2;
                Console.WriteLine("{0}*{1}*{0}", new string('.', sides), new string('.', dressSize*3 - (sides*2 + 2)));
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', dressSize - 2), new string('.', dressSize));
            sides = 1;
            for (int i = 0; i < (dressSize / 2)-1; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', dressSize - 3 - sides), new string('.', sides), new string('.', dressSize));
                sides += 2;
            }
            // lower half

            

            for (int i = 0; i < dressSize - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', dressSize - 1 - i),


                    new string('.', dressSize + 2 * i));
            }
            Console.WriteLine("{0}", new string('*', 3 * dressSize));

        }
    }
}
