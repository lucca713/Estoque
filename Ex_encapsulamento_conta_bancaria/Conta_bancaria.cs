using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_encapsulamento_conta_bancaria
{
    internal class Conta_bancaria
    {
        //ja encapsulados
        public  int Id { get; private set; }
        public string Name { get; private set; }
        public double Valor { get; private set; }

        //construtor
        public Conta_bancaria()
        {
            Valor = 0.0;
        }

        public Conta_bancaria(int id, string name):this()
        {
            Id = id;
            Name = name;
            
        }

        public Conta_bancaria(int id, string name, double valor) : this(id, name)
        {
            Valor = valor;
        }

        public void AddConta(double valor)
        {

            Valor += (valor - 5);

        }


        public override string ToString()
        {
            return $"Conta {Id}, Titular: {Name}, Saldo: R$ {Valor}";
        }

    }

}
