using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteProdutoEVenda
{
   internal class Produto 
    {
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nomeProduto = "", int quantidade =0)
        {
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
        }
    }
}
