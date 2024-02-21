using System;

class ContaBancaria
{
    private string numeroConta;
    private string nomeTitular;
    private double saldo;

    public ContaBancaria(string numeroConta, string nomeTitular, double saldoInicial)
    {
        this.numeroConta = numeroConta;
        this.nomeTitular = nomeTitular;
        this.saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
        else
        {
            Console.WriteLine("O valor do saque deve ser maior que zero.");
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Número da Conta: {numeroConta}");
        Console.WriteLine($"Nome do Titular: {nomeTitular}");
        Console.WriteLine($"Saldo Atual: R${saldo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria("000000", "Lucas", 150000.0);

        Console.WriteLine("Informações Iniciais da Conta:");
        conta.ExibirInformacoes();

        conta.Depositar(5000.0);

        conta.Sacar(20000.0);

        Console.WriteLine("\nInformações Atualizadas da Conta:");
        conta.ExibirInformacoes();
    }
}
