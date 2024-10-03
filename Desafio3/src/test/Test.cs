using Desafio3.entity;
using System;
using System.Collections.Generic;

namespace Desafio3
{
    class Test
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("12233526789", "John", "Doe");

            List<ProductEnum> products = new List<ProductEnum>
            {
                ProductEnum.Electronic,
                ProductEnum.Food,
                ProductEnum.Clothing
            };

            foreach (var productEnum in products)
            {
                Product product = Factory.CreateProduct(productEnum);
                customer.cart.AddProduct(productEnum);
            }

            Console.WriteLine("\nCart: ");
            Console.WriteLine(customer.cart);

            
            // Com sobrecarga optional
            
            /*
             ElectronicProduct electronicProduct = new ElectronicProduct("phone", 1500); 
            customer.cart.AddProduct(electronicProduct);
            double phoneFinalPrice = electronicProduct.totalValue(ProductEnum.Electronic);
            Console.WriteLine($"\nFinal price for {electronicProduct}: R$ {phoneFinalPrice:F2}");*/

            foreach (var productEnum in products)
            {
                Product product = Factory.CreateProduct(productEnum);
                double finalPrice = product.totalValue(productEnum);
                Console.WriteLine($"Final price for {product}: R$ {finalPrice:F2}");
            }

            Console.WriteLine("\nTotal: R$ " + customer.cart.GetTotalValue().ToString("F2"));
        }
    }
}