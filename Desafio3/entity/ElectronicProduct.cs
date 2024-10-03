namespace Desafio3.entity;

public class ElectronicProduct : Product
{
    public ElectronicProduct()
    {
        this.name = "Computer";
        this.value = 2000.00;
    }
    
    public ElectronicProduct(string name, double value)
    {
        this.name = name;
        this.value = value;
    }
}