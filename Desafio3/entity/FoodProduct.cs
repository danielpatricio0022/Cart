namespace Desafio3.entity;

public class FoodProduct : Product
{
    public FoodProduct()
    {
        this.name = "Cereal";
        this.value = 10.00 ;
    }
    public FoodProduct(string name, double value)
    {
        this.name = name;
        this.value = value ;
    }
    
    
    
}