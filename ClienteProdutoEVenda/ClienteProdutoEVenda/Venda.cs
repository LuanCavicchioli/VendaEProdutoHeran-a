using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteProdutoEVenda
{
    internal class Venda : Cliente
    {
        public int Valor;
        public int Qnt;

        public Venda(int valor = 0, int qnt = 0)
        {
            Valor =valor;
            Qnt = qnt;
        }
        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine("A quantidade de produtos foi: {0}", Qnt);
            Console.WriteLine("O valor total foi:{0}", Valor);
        }
    }
}
