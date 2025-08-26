using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_aumento_salario_poo
{
    internal class Funcionario
    {
        public string Nome {  get; set; }

        public double SalarioBruto { get; set; }

        public double Imposto { get; set; } 

        public double SalarioLiquido(double imposto)
        {
            return  SalarioBruto -= imposto;
        }

        public void AumentoDeSalario(double qtd_aumento) { 
             SalarioBruto += SalarioBruto * (qtd_aumento/100);
        }

        public override string ToString() {
            return $"{Nome}, Salario de: {SalarioBruto}";
        }
    }
}
