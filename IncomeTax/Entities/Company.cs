using IncomeTax.Entities;

namespace IncomeTax.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        /*
        
        Pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10
        funcionários, ela paga 14% de imposto.
        Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
        400000 * 14% = 56000.00

        */

        public override double Tax()
        {
            double tax = 0.0;

            if (NumberOfEmployees <= 10)
            {
                tax = 0.16;
            }
            else
            {
                tax = 0.14;
            }

            return AnualIncome * tax;
        }
    }
}
