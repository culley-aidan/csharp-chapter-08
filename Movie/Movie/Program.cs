using System;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a movie name: ");
            string movieName = Console.ReadLine();
            Movie(movieName);
            Console.Write("Enter a playtime: ");
            int.TryParse(Console.ReadLine(), out int playtime);
            Movie(movieName, playtime);
        }

        static void Movie(string movie, int runtime = 90)
        {
            Console.WriteLine("Current movie playing: {0}, Runtime: {1}", movie, runtime);
        }
    }
}
