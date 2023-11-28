using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = new string[3] {"En mening", "En annan mening", "En tredje mening"};
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
                Console.WriteLine();
            }

        }
    }
}