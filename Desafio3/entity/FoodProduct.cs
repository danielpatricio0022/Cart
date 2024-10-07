namespace Desafio3.entity;

public class FoodProduct (string name, decimal value) : Product(name, value)
{
  
  /*  public FoodProduct()
    {
        this.name = "Cereal";
        this.value = 10.00m ;
    }*/
  
    public override decimal toCalculate()
    {
        decimal additionalDiscount = 0.03m; 
        decimal basePrice = totalValue(); 
        return basePrice - value * additionalDiscount; 
    }
}