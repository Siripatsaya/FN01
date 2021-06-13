using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main()
        {
            int First = int.Parse(Console.ReadLine());
            int Second = int.Parse(Console.ReadLine());
            int Third = int.Parse(Console.ReadLine());
            int Fourth = int.Parse(Console.ReadLine());
            int Fifth = int.Parse(Console.ReadLine());
            int Sixth = int.Parse(Console.ReadLine());
            int Seventh = int.Parse(Console.ReadLine());
            int Eighth = int.Parse(Console.ReadLine());
            int Ninth = int.Parse(Console.ReadLine());
            int swapRound = int.Parse(Console.ReadLine());
            while (swapRound > 0)
            {
                Swap(ref First, ref Second);
                Swap(ref Second, ref Third);
                Swap(ref Third, ref Fourth);
                Swap(ref Fourth, ref Fifth);
                Swap(ref Fifth, ref Sixth);
                Swap(ref Sixth, ref Seventh);
                Swap(ref Seventh, ref Eighth);
                Swap(ref Eighth, ref Ninth );
                Swap(ref Ninth, ref First);
                swapRound--;
            }
            Console.Write(First);
            Console.Write(Second);
            Console.WriteLine(Third);
            Console.Write(Fourth);
            Console.Write(Fifth);
            Console.WriteLine(Sixth);
            Console.Write(Seventh);
            Console.Write(Eighth);
            Console.Write(Ninth);           
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}


        



