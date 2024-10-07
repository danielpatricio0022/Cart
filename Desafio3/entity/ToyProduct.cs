namespace Desafio3.entity;

public class ToyProduct (string name, decimal value) : Product(name, value)
{
    public override decimal toCalculate()
    {
        return totalValue(); 
    }
}