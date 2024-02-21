using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    class Triangulo
    {
        double lado1;
        double lado2;
        double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }
        public bool LadosIguais()
        {
            return lado1 == lado2 && lado2 == lado3;
        }
        public double CalcularArea()
        {
            double s = (lado1 * lado2 * lado3) / 2;
            return Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }
        public void TrianguloValido()
        {
            if (LadosIguais())
            {
                Console.WriteLine("O triangulo é válido(todos os lados são iguais)");
            }
            else
            {
                Console.WriteLine("O triangulo é inválido(todos os lados não são iguais");
            }
        }
        public void Area()
        {
            Console.WriteLine($"Área do triangulo é: {CalcularArea():F2}");
        }
        class Program
        {
            static void Main(string[] args)
            {

                Triangulo triangulo = new Triangulo(5, 5, 4);
                triangulo.TrianguloValido();
                triangulo.Area();


            }

        }
    }
}
    
        
    
    
    

       



///Crie uma classe chamada “Triângulo” com atributos para armazenar os três lados do
///triângulo. Implemente métodos para verificar se é um triângulo válido e calcular sua área.