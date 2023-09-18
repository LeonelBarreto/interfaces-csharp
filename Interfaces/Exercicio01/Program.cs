using System.Globalization;
using Exercicio01.Entities;
using Exercicio01.Services;

namespace Exercicio01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrar com os dados da locação");
        Console.Write("Modelo do carro: ");
        string model = Console.ReadLine();

        Console.WriteLine();
        Console.Write("Data da retirada (MM/dd/yyyy HH:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Data da devolução (MM/dd/yyyy HH:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.Write("Informe o valor por hora: ");
        double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Informe o valor por dia: ");
        double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        CarRental carRental = new CarRental(start, finish, new Vehicle(model));

        RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine();
        Console.WriteLine("INVOICE:");
        Console.WriteLine(carRental.Invoice);
    }
}

