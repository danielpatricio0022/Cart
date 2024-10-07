using Desafio3.entity;

namespace Desafio3
{
    class Test
    {
        static void Main(string[] args)
        {
            /*Customer customer1 = new Customer("12233526789", "John", "Doe");

            List<ProductEnum> products = new List<ProductEnum>
            {
                ProductEnum.Electronic,
                ProductEnum.Food,
                ProductEnum.Clothing
            };

            foreach (var productEnum in products)
            {
                Product product1 = Factory.CreateProduct(productEnum);
                customer.cart.AddProduct(productEnum);
            }*/
            
            /*foreach (var productEnum in products)
           {
               Product product = Factory.CreateProduct(productEnum);
               double finalPrice = product.totalValue(productEnum);
               Console.WriteLine($"Final price for {product}: R$ {finalPrice:F2}");
           }
             double phoneFinalPrice = electronicProduct.totalValue(ProductEnum.Electronic);
           */
            
            Customer customer = new Customer("12233526789", "John", "Doe");

            ElectronicProduct electronicProduct = new ElectronicProduct("phone", 1000.00m);
            FoodProduct foodProduct = new FoodProduct("Cereal", 50.00m);
            ClothingProduct clothingProduct = new ClothingProduct("shirt", 100.00m);
            Product tool = new ToolProduct("Hammer", 150.00m);
            Product toy = new ToyProduct("Action Figure", 80.00m);
            Product drink = new DrinkProduct("Vodka", 200.00m);

            customer.cart.AddProduct(electronicProduct);
            customer.cart.AddProduct(foodProduct);
            customer.cart.AddProduct(clothingProduct);

            decimal phoneFinalPrice = electronicProduct.toCalculate();
            decimal foodFinalPrice = foodProduct.toCalculate();
            decimal clothingFinalPrice = clothingProduct.toCalculate();

            Console.WriteLine("\nCart: ");
            Console.WriteLine(customer.cart);

            Console.WriteLine($"\n price: {electronicProduct.name}: R$ {phoneFinalPrice:F2}");
            Console.WriteLine($" price: {foodProduct.name}: R$ {foodFinalPrice:F2}");
            Console.WriteLine($" price: {clothingProduct.name}: R$ {clothingFinalPrice:F2}");
            Console.WriteLine(tool.ToString());
            Console.WriteLine(toy.ToString());
            Console.WriteLine(drink.ToString());

            Console.WriteLine("\nTotal Cart: R$ " + customer.cart.GetTotalValue().ToString("F1"));
        }
    }
    
}