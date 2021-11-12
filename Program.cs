using System;

namespace ghk
{
    class Program
    {
        static void Main(string[] args)
        {
            string helicopter = Console.ReadLine();

            char [] Helicopter = helicopter.ToCharArray();

            Array.Reverse(Helicopter);

            string HELICOPTER = new string (Helicopter);

            if(helicopter.Equals(HELICOPTER)){
                Console.WriteLine("helicopter");
            }else{
                Console.WriteLine("HELICOPTER");
            }
        }
    }
}
