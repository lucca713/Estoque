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

        public void AdicionarProduto(int qtd)
        {
            Qtd_estoque += qtd;
          
        }

        public void RemoverProduto(int qtd)
        {
            Qtd_estoque -= qtd;
        }

        //usado quando eu printo o objeto inteiro ele retorna essa frase como default
        public override string ToString()
        {
            return $"{Nome_produto} , custa R$ {Preco}, tem {Qtd_estoque} no estoque";
        }

    }
}
