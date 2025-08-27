using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_contrutores
{
    internal class Produto
    {
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        //construtores
        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco):this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            //pois quantidade nao foi instanciado no contrutor de cima
            Quantidade = quantidade;
        }
    }
}
