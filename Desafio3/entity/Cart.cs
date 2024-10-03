namespace Desafio3.entity
{
    public class Cart
    {
        private List<Product> _products;

        public Cart()
        {
            _products = new List<Product>();
        }
        
        public void AddProduct(ProductEnum productEnum)
        {
            Product product = Factory.CreateProduct(productEnum); 
            _products.Add(product);
        }
        
        public void AddProduct(Product product) //sobrecarga
        {
            _products.Add(product);
        }
        
        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }
        
        public double GetTotalValue()
        {
            double total = 0;
            foreach (var product in _products)
            {
                total += product.value; 
            }
            return total;
        }
        
        public override string ToString()
        {
            if (_products.Count == 0)
            {
                return "cart empty";
            }

            string productList = "";
            
            foreach (var product in _products)
            {
                productList += product.ToString() + "\n"; 
            }

            return productList;
        }
    }
}