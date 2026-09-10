using System;

namespace AreaVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vyber geometricky tvar");
            Console.WriteLine("1, ctverec");
            Console.WriteLine("2, kruh");

            var shape = Console.ReadLine();

            switch (shape)
            {
                case "1":
                    CalculateSquare();
                    break;
                case "2":
                    CalculateCircle();
                    break;
                default:
                    Console.WriteLine("neplatna hodnota!!!");
                    break;
            }
        }

        static void CalculateSquare()
        {
            Console.WriteLine("zadej a");
            string input = Console.ReadLine();

            var a = double.Parse(input);

            var area = a * a;
            var perimetr = 4 * a; 

            Console.WriteLine($"Obsah: {area}");
            Console.WriteLine($"Obvod: {perimetr}");
        }

        static void CalculateCircle()
        {
            Console.WriteLine("zadej polomer r");
            string input = Console.ReadLine();

            var r = double.Parse(input);

            var area = Math.PI * r * r;
            var perimetr = 2 * Math.PI * r;

            Console.WriteLine($"Obsah: {area}");
            Console.WriteLine($"Obvod: {perimetr}");
        }
    }
}