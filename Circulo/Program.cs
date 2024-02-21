using System;

class Circulo
{
    private double raio;

    public Circulo(double raio)
    {
        this.raio = raio;
    }

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(raio, 2);
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * raio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double raio = 5.0;

        Circulo circulo = new Circulo(raio);

        Console.WriteLine("Área do círculo: " + circulo.CalcularArea());

        Console.WriteLine("Perímetro do círculo: " + circulo.CalcularPerimetro());
    }
}
