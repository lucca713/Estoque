using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Produto
    {
        public string Nome_produto {get;set;}
        public double Preco {get;set;}
        public int Qtd_estoque {get;set;}

        public double ValorTotalEmEstoque() { 
            return Preco * Qtd_estoque;

        }
    }
}
