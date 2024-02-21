using System;

public class Funcionario
{
    
    public string Nome { get; set; }
    public decimal Salario { get; set; }
    public string Cargo { get; set; }

    
    public Funcionario(string nome, decimal salario, string cargo)
    {
        Nome = nome;
        Salario = salario;
        Cargo = cargo;
    }

    
    public decimal SalarioLiquido(decimal impostos, decimal beneficios)
    {
        
        decimal salarioLiquido = Salario - impostos + beneficios;
        return salarioLiquido;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Funcionario funcionario = new Funcionario("Lucas", 1412, "Gerente");

        
        decimal salarioLiquido = funcionario.SalarioLiquido(400, 1412);

        
        Console.WriteLine($"O salário líquido de {funcionario.Nome} como {funcionario.Cargo} é: R${salarioLiquido}");
    }
}
