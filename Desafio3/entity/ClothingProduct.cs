namespace Desafio3.entity;

public class ClothingProduct : Product
{
    public ClothingProduct()
    {
        this.name = "Clothing";
        this.value = 250.00m;
    }
    
    public ClothingProduct(string name, decimal value)
    {
        this.name = name;
        this.value = value;
    }

    public override decimal toCalculate()
    {
        decimal additionalDiscount = 0.07m; 
        decimal discountedValue = totalValue(); 
        return discountedValue * (1 - additionalDiscount); 
    }
    
}