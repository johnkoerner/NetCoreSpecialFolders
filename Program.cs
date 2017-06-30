using System;

namespace NetCoreSpecialFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Environment.SpecialFolder sf in Enum.GetValues(typeof(System.Environment.SpecialFolder)))
            {
                Console.WriteLine($"{sf.ToString()}, {Environment.GetFolderPath(sf)}");
            }
            Console.ReadLine();
        }
    }
}
