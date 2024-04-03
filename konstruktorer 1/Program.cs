using System;
namespace bilinformation
{
    public class program
    {
        public static void Main(string[] args)
        {
            bilinformation p = new bilinformation("v60", 20, "28 april 2002", "volvo", 20000);

            Console.WriteLine(p.modell);
            Console.WriteLine(p.ålder);
            Console.WriteLine(p.tillverknings_datum);
            Console.WriteLine(p.tillverkare);
            Console.WriteLine(p.priss);
        }
    }
}