using SimuladorBancario.Models;

namespace SimuladorBancario;

internal class Program
{
    static void Main(string[] args)
    {

        var contaCorrente = new ContaCorrente("Diego S");

        Console.WriteLine("=== CONTA CORRENTE ===");
        contaCorrente.Depositar(1000);
        contaCorrente.Sacar(300);
        contaCorrente.Sacar(900); // usa limite
        contaCorrente.ExibirSaldoComLimite();

        Console.WriteLine();
        Console.WriteLine("==============================");
        Console.WriteLine();

        var contaPoupanca = new ContaPoupanca("Maria P");

        Console.WriteLine("=== CONTA POUPANÇA ===");
        contaPoupanca.Depositar(2000);
        contaPoupanca.Exibir();

        Console.WriteLine();
        Console.WriteLine("Simulação de rendimento:");
        contaPoupanca.SimularRendimento(3);

        Console.ReadKey();


    }
}


