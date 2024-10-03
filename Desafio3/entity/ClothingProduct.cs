namespace Desafio3.entity;

public class ClothingProduct : Product
{
    public ClothingProduct()
    {
        this.name = "Clothing";
        this.value = 250.00;
    }
    
    public ClothingProduct(string name, double value)
    {
        this.name = name;
        this.value = value ;
    }

    
}