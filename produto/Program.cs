namespace produto
{
    class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public double Total()
        {
            return preco * quantidade;
        }

        public bool Disponivel()
        {
            return quantidade > 0;
        }
        public void Infos()
        {
            Console.WriteLine($"Nome> {nome}");
            Console.WriteLine($"Preço: {preco:F2}");
            Console.WriteLine($"Valor em estoque: {Total():F2}");
            Console.WriteLine($"O Produto está disponível? {(Disponivel() ? "Sim" : "Não")}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("Biscoito", 3.99, 20);
            produto1.Infos();
        }

    }
}
//Implemente uma classe chamada “Produto” que possua atributos para armazenar o nome,
//o preço e a quantidade em estoque. Adicione métodos para calcular o valor total em
//estoque e verificar se o produto está disponível.
