using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismTask
{
    class Library
    {
        public Product[] products;
        public void AddProduct(Product product)
        {
           Array.Resize(ref products, products.Length + 1);
           products[products.Length - 1] = product;
        }
        public void GetProductsByPrice(double minPrice, double maxPrice)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Price>minPrice && products[i].Price<maxPrice)
                {
                    
                }
            }
        }
        public void GetProductByName(string str)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name==str)
                {

                }
            }  
        }
    }
}
