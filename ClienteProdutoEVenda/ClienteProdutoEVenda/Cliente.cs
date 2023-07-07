using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteProdutoEVenda
{
    internal class Cliente : Produto
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }

        public Cliente(int Idcliente =0, string nome = "", int cpf = 0) 
        {
            IdCliente = Idcliente;
            Nome = nome;
            CPF = cpf;
        }
        public virtual void MostrarDetalhes()
        {
            Console.WriteLine("ID DO CLIENTE:{0}", IdCliente);
            Console.WriteLine("Nome do cliente: {0}",Nome);
            Console.WriteLine("CPF: {0}",CPF);
            Console.WriteLine("Nome Do Produto Comprado:{0}",NomeProduto);
            
        }
    }
}   
