namespace IncomeTax.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; protected set; }
        public double AnualIncome { get; protected set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
