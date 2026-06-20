

namespace SimuladorBancario.Models
{
    internal class ContaPoupanca : Conta
    {

        public decimal TaxaRendimento { get; protected set; }

        public ContaPoupanca(string titular)
            : base(titular)
        {
            TaxaRendimento = 0.01m;
        }

        public void AplicarRendimento()
        {
            Saldo += TaxaRendimento * Saldo;
        }

        public override void Depositar(decimal valor)
        {
            Console.WriteLine("Operação realizada na Conta Poupança");
            base.Depositar(valor);
        }

        public override void Sacar(decimal valor)
        {
            Console.WriteLine("Operação realizada na Conta Poupança");
            base.Sacar(valor);
        }


        public void SimularRendimento(int meses)
        {
            decimal saldoInicial = Saldo;

            for (int i = 1; i <= meses; i++)
            {
                AplicarRendimento();

                Console.WriteLine($"""
            Mês {i}
            Saldo atual: {Saldo:C}
            Rendimento acumulado: {(Saldo - saldoInicial):C}
            -------------------------
            """);
            }
        }
    }
}

