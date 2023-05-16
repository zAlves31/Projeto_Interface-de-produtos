using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_produto_interface
{
    // interface para a classe Carrinho
    public interface ICarrinho
    {
        // definir quais os metodos deverao ser implementados
        // na classe que herdar desta interface

        // CRUD : Create / Read / Update / Delete

        // Create
        void Adicionar(Produto produto);

        // Read
        void Listar();

        // Update
        void Atualizar(int codigo,Produto _novoProduto);

        // Delete
        void Remover(Produto produto);
    }
}