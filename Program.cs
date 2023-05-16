using Projeto_produto_interface;

// instancia do nosso objeto da classe carrinho
Carrinho carrinho = new Carrinho();

Produto p1 = new Produto (10, "Call of Duty", 480f);
Produto p2 = new Produto (12, "Minecraft", 80f);
Produto p3 = new Produto (15, "Dragon Ball Xenoverse 2", 250f);

// adicionar
carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);


//Listar
carrinho.Listar();

// Valor do carrinho
carrinho.ValorTotal();

// Remover
carrinho.Remover(p1);

// Listar
carrinho.Listar();

// Valor total
carrinho.ValorTotal();

//Atualizar
    // criar um novo objeto com os dados atualizados
Produto produtoAtualizado = new Produto();
produtoAtualizado.Nome = "Marvel Spider Man PS4";
produtoAtualizado.Preco = 100f;

// atualizar para novo objeto
carrinho.Atualizar(12, produtoAtualizado);

