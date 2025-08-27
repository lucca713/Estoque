namespace Aula_contrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Produto produto = new Produto("TV",500.00,10);

            produto.Nome = "Tv 52''";

            Console.WriteLine(produto.Nome);
        }
    }
}
