using System;
namespace Word
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var lowerCase = 0;
            var upperCase = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                    upperCase++;
                else
                    lowerCase++;
            }

            var result = (lowerCase >= upperCase) ? input.ToLower() : input.ToUpper();
            Console.WriteLine(result);
        }
    }
}
