using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {12,14,11,10};
            Console.WriteLine( Program.solution(A));
        }

        public static int solution( int[] A)
        {
            if (A.Length != 0 )
            {
                List<int> B = A.ToList();
                var result = 0;
                B.Sort();

                for (int i = 1; i < B.Count; i++)
                {
                    if (B.ElementAt(i) - B.ElementAt(i - 1) != 1)
                    {
                        result = (B.ElementAt(i) + B.ElementAt(i - 1)) / 2;
                    }
                }
                return result;
            }
            return 0;
        }
    }
}
