using System;

namespace DenisTodorGitTest
{
    class DenisTodorGitTest
    {
        static void Main(string[] args)
        {
            // upper half



            // lower half
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', n - 1 - i),
                    new string('.', n + 2 * i));
            }
            Console.WriteLine("{0}", new string('*', 3 * n));

        }
    }
}
