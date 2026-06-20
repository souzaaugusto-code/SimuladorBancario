namespace SimuladorBancario.Models
{
    abstract class Conta
    {
        public string Titular { get; set; }
        public string NumeroConta { get; protected set; } = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        public decimal Saldo { get; protected set; } = 0m;

        public Conta(string titular)
        {
            Titular = titular;
        }

        public virtual void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Operação inválida");
            }
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque no valor de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }
        }

        public void Exibir()
        {
            Console.WriteLine($"""
            Titular: {Titular}
            Conta: {NumeroConta}
            Saldo: {Saldo:C}
            """);
        }
    }
}
