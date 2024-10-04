namespace Desafio3.entity;

public class FoodProduct : Product
{
    public FoodProduct()
    {
        this.name = "Cereal";
        this.value = 10.00m ;
    }
    public FoodProduct(string name, decimal value)
    {
        this.name = name;
        this.value = value;
    }

    public override decimal toCalculate()
    {
        decimal additionalDiscount = 0.03m; 
        decimal discountedValue = totalValue(); 
        return discountedValue * (1 - additionalDiscount); 
    }
}