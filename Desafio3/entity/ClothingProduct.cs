namespace Desafio3.entity;

public class ClothingProduct(string name, decimal value) : Product(name, value)
{
   /* public ClothingProduct()
    {
        this.name = "Clothing";
        this.value = 250.00m;
    }*/
   
   public override decimal toCalculate()
   {
       decimal price = base.toCalculate();
       decimal additionalDiscount = 0.07m; 
       decimal finalPrice = price - (value * additionalDiscount);

       return finalPrice;
   }
    
}