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
            long bytes1 = GC.GetTotalMemory(false); //Memory in bytes
            byte[] memory = new byte[1000 * 1000 * 10]; //Ten million bytes
            memory[0] = 1; //setting memory(To prevent allocation to be maximized out)
            long bytes2 = GC.GetTotalMemory(false); //Getting memory
            long bytes3 = GC.GetTotalMemory(false); //Getting memory
            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2-bytes1);
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 -bytes2);

        }
    }
}
