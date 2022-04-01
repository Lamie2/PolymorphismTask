using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"ad daxil edin: ");
            string name = Console.ReadLine();
            Console.WriteLine("soyad daxil edin:");
            string surname = Console.ReadLine();
            Console.WriteLine("yasinizi daxil edin");
            byte age= Byte.Parse(Console.ReadLine());
            Console.WriteLine("saatliq maasi daxil edin: ");
            double salaryOfHour = Double.Parse(Console.ReadLine());
            Console.WriteLine("is saatini daxil edin: ");
            double workingHour = Double.Parse(Console.ReadLine());

            Employee employee = new Employee()
            
        }
    }
}
