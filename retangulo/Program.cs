using System;

class Retangulo
{
    private double largura;
    private double altura;

    public Retangulo(double largura, double altura)
    {
        this.largura = largura;
        this.altura = altura;
    }

    public double CalcularArea()
    {
        return largura * altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (largura + altura);
    }
}

class Program
{
    static void Main(string[] args)
    {
        double largura = 5.0;
        double altura = 3.0;

        Retangulo retangulo = new Retangulo(largura, altura);

        Console.WriteLine("Área do retângulo: " + retangulo.CalcularArea());

        Console.WriteLine("Perímetro do retângulo: " + retangulo.CalcularPerimetro());
    }
}
