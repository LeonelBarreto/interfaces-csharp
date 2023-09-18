using System.Globalization;

namespace Exercicio01.Entities
{
	public class Invoice
	{
		public double BasicPayment { get; set; }
		public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Valor base: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxas: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal do Pagamento: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}