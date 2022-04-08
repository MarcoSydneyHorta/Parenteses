using System;

namespace Parenteses
{

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.Write("Type the characters (){}[] in the order you want :");
            if (solution.IsValid(Console.ReadLine()))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
 
        }
    }
}
