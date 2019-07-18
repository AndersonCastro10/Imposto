using IncomeTax.Entities;

namespace IncomeTax.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        /*Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto.Pessoas com
        renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50%
        destes gastos são abatidos no imposto.

        Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto
        fica: (50000 * 25%) - (2000 * 50%) = 11500.00*/

        public override double Tax()
        {
            double tax = 0.0;

            if (AnualIncome < 20000)
            {
                tax = 0.15;
            }
            else
            {
                tax = 0.25;
            }

            return (AnualIncome * tax) - (HealthExpenditures * 0.5) ;
        }
    }
}
