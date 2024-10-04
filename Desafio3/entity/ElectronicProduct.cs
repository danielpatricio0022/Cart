namespace Desafio3.entity;

public class ElectronicProduct : Product
{
    public ElectronicProduct()
    {
        this.name = "Computer";
        this.value = 2000.00m;
    }
    
    public ElectronicProduct(string name, decimal value)
    {
        this.name = name;
        this.value = value;
    }

    public override decimal toCalculate()
    {
        decimal additionalDiscount = 0.05m; 
        decimal discountedValue = totalValue(); 
        return discountedValue * (1 - additionalDiscount); 
    }
}