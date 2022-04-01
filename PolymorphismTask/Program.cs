using System;

namespace PolymorphismTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();


           
            Console.WriteLine($"productin qiymetini daxil edin : ");
            double price = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Max qiymet daxil edin : ");
            double maxPrice = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Min qiymet daxil edin : ");
            double minPrice = Double.Parse(Console.ReadLine());
            Library.GetProductsByPrice(minPrice, maxPrice);

            Console.WriteLine("productin adini daxil edin : ");
            string name = Console.ReadLine();
            Library.GetProductByName(name);

        }
    }
}
