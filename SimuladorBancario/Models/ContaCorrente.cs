
namespace SimuladorBancario.Models
{
    internal class ContaCorrente : Conta
    {
        public decimal LimiteTotal { get; protected set; }

        public ContaCorrente(string titular)
            : base(titular)

        {
            LimiteTotal = 500m;

        }


        public override void Depositar(decimal valor)
        {
            Console.WriteLine("Operação realizada na Conta Corrente");
            base.Depositar(valor);
        }


        public override void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Operação inválida.");
            }
            else if (valor <= Saldo)
            {
                base.Sacar(valor);
            }
            else if (valor <= Saldo + LimiteTotal)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso usando o limite.");
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }
        }


        public void ExibirSaldoComLimite()
        {
            decimal limiteDisponivel;

            if (Saldo < 0)
            {
                limiteDisponivel = LimiteTotal + Saldo;
            }
            else
            {
                limiteDisponivel = LimiteTotal;
            }

            Console.WriteLine($"""
             Titular: {Titular}
             Conta: {NumeroConta}
             Saldo: {Saldo:C}
             Limite total: {LimiteTotal:C}
             Limite disponível: {limiteDisponivel:C}
             """);
        }
    }
}


