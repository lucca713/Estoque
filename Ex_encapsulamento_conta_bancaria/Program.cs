using static System.Net.Mime.MediaTypeNames;

namespace Ex_encapsulamento_conta_bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero da conta");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular da conta");
            var nome = Console.ReadLine();

            Console.WriteLine("havera deposito primeiro? ");
            var choise = Console.ReadLine();

            if (choise == "N")
            {
                Conta_bancaria conta = new Conta_bancaria(id, nome);

                Console.WriteLine(conta);
            }
            else {

                Console.WriteLine("informe o deposito");
                var valor_deposito = double.Parse(Console.ReadLine());

                Conta_bancaria conta = new Conta_bancaria(id, nome, valor_deposito);

                Console.WriteLine(conta);

                Console.WriteLine("entre com um valor para Adicionar na conta: ");
                var valor_para_depositar = double.Parse(Console.ReadLine());

                conta.AddConta(valor_para_depositar);
                Console.WriteLine(conta);
            }

            

            
        }
    }
}
