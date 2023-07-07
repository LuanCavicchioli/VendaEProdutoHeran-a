using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteProdutoEVenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Cliente cliente = new Cliente();
            cliente.IdCliente = 1;
            cliente.Nome = "Junin Do Corte";
            cliente.CPF = 1;
            cliente.NomeProduto = "Macã";

            cliente.MostrarDetalhes();

            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Venda venda = new Venda();

            venda.IdCliente = 2;
            venda.Nome = "Junin Arrasta";
            venda.CPF = 2;
            venda.NomeProduto = "Batata";
            venda.Valor = 10;
            venda.Qnt = 5;

            venda.MostrarDetalhes();
            

        }
    }
}
