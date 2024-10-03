namespace Desafio3.entity;

public abstract class Product: ProductI
{
   protected string name { get; set; }
   public double value { get; protected set; }
   
   public double totalValue(ProductEnum category)
   {
       double baseDiscount = 0.05;  
       double additionalDiscount = (double)category / 100;  
            
       double totalDiscount = baseDiscount + additionalDiscount - (baseDiscount * additionalDiscount);
       double discounted = value * (1 - totalDiscount);


       return discounted;
   }

    public override string ToString()
    {
        return $"{nameof(name)}: {name}, {nameof(value)}: {value}";
    }
}