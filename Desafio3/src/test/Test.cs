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

               
                double finalPrice = product.totalValue(productEnum);
                Console.WriteLine($"final price {product}: R$ {finalPrice:F2}");
            }

            Console.WriteLine("\n Customer: " + customer);
            Console.WriteLine(" \n Cart: ");
            Console.WriteLine( customer.cart);
            Console.WriteLine("Total: R$ " + customer.cart.GetTotalValue().ToString("F2"));
        }
    }
}