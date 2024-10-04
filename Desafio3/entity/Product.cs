namespace Desafio3.entity
{
   
    public abstract class Product
    {
        public string name { get; set; }
        public decimal value { get; protected set; }

        public decimal totalValue()
        {
            decimal baseDiscount = 0.05m; 
            return value * (1 - baseDiscount); 
        }

        public abstract decimal toCalculate();

        public override string ToString()
        {
            return $"{nameof(name)}: {name}, {nameof(value)}: {value}, Total Value: {toCalculate():F2}";
        }
    }
   
    
}