using System;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to world of garbage collection");
            long memory1 = GC.GetTotalMemory(false);
            {
                //Allocating array and making it unreachable
                int[] values = new int[50000];
                values = null;
            }
            long memory2 = GC.GetTotalMemory(false);
            {
                //collecting garbage
                GC.Collect();

            }
            long memory3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(memory1);
                Console.WriteLine(memory2);
                Console.WriteLine(memory3);
            }
            Console.WriteLine("###############################");

        }
    }
}
