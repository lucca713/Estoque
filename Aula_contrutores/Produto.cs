using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_contrutores
{
    internal class Produto
    {
        private string _nome { get; set; }

        private double _preco { get; set; }

        private int _quantidade { get; set; }

        //encpasulamento por propriedade

        public string Nome { 

            get { return _nome; } 


            set { if (value != null && value.Length > 1) { 
                _nome = value;
                
                } 
            } 
        }



        /*encapsulamento
        public string GetNome() {  return _nome; }

        public string SetNome(string nome) { return _nome = nome; }
        */

        //construtores
        public Produto()
        {
            _quantidade = 10;
        }

        public Produto(string nome, double preco):this()
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            //pois quantidade nao foi instanciado no contrutor de cima
            _quantidade = quantidade;
        }
    }
}
