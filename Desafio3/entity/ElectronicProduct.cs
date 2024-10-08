namespace Desafio3.entity;

public class ElectronicProduct(string name, decimal value) : Product(name, value)
{
   
    /*public ElectronicProduct()
    {
        this.name = "Computer";
        this.value = 2000.00m;
    }*/

    public override decimal toCalculate()
    {
        decimal price = base.toCalculate();
        decimal additionalDiscount = 0.05m; 
        decimal finalPrice = price - (value * additionalDiscount);

        return finalPrice;
    }
}