using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_produto_interface
{
    public class Carrinho : ICarrinho
    {
        public float valor {get; set;}

    // Lista onde vamos manipular os objetos
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (var Produto in carrinho)
                {
                    Console.WriteLine($"Codigo: {Produto.Codigo} - Nome: {Produto.Nome} - Preco: {Produto.Preco:C}");
                    
                }
            }
        }

        public void Atualizar(int codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = _novoProduto.Preco;
        }


        public void Remover(Produto produto)
        {
            carrinho.Remove(produto);
        }
        public void ValorTotal()
        {
            valor = 0;

            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                   valor += item.Preco;
                }
                Console.WriteLine($"o total do seu carrinho esta em : {valor:C}");
                
            }
            else
            {
                Console.WriteLine($"Seu carrinho esta vazio");
                
            }
        }

    }   
}