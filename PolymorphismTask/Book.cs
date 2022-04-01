using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismTask
{
    class Book:Product
    {
        public string Author;
        public string Genre;
        public override void GetInfo()
        {
            Console.WriteLine($"author {Author}, genre: {Genre}");
        }
    }
}
