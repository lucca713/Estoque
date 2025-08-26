namespace Ex_aumento_salario_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando funcionario
            Funcionario funcionario = new Funcionario();

            //entrada dos dados
            Console.WriteLine("Digite o nome");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salario bruto");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do imposto");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            //calculo salario liquido
            funcionario.SalarioLiquido(funcionario.Imposto);

            Console.WriteLine($"Funcionario: {funcionario}");

            //calculo aumento de salario

            Console.WriteLine("Digite o aumento do salario");
            double Aumento = double.Parse(Console.ReadLine());
            funcionario.AumentoDeSalario(Aumento);

            Console.WriteLine($"Dados atualizados: {funcionario}");

        }
    }
}
