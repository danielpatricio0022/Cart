namespace Desafio3.entity
{
    public class Customer
    {
        protected string cpf { get; set; }
        protected string firstName { get; set; }
        protected string lastName { get; set; }

        public Cart cart { get; set; }

        public Customer(string cpf, string firstName, string lastName)
        {
            this.cpf = cpf;
            this.firstName = firstName;
            this.lastName = lastName;
            cart = new Cart();
        }

        public override string ToString()
        {
            return $"{nameof(cpf)}: {cpf}, {nameof(firstName)}: {firstName}, {nameof(lastName)}: {lastName}";
        }
    }
}