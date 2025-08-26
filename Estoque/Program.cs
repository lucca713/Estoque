using System.Globalization;
namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Produto produto = new Produto();

            Console.WriteLine("Digite o nome do produto: ");
            produto.Nome_produto = Console.ReadLine();

            Console.WriteLine("Preco R$ do produto: ");
            produto.Preco= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade em estoque: ");
            produto.Qtd_estoque = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto {produto}");

            int Qtd_add = int.Parse(Console.ReadLine());

            produto.AdicionarProduto(Qtd_add);

            Console.WriteLine($"Dados do produto {produto}");

            int Qtd_remove = int.Parse(Console.ReadLine());

            produto.RemoverProduto(Qtd_remove);

            Console.WriteLine($"Dados do produto {produto}");
        }
    }
}
