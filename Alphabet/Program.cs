using System;
using System.Collections.Generic;


namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var input = Console.ReadLine();
            HashSet<char> chars = new HashSet<char>(input.ToLower());
            if (chars.Count == 26)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
