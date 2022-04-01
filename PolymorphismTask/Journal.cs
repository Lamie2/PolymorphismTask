using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismTask
{
    class Journal:Product
    {
        public string Company;
        public override void GetInfo()
        {
            Console.WriteLine($"company: {Company}");
        }
    }
}
