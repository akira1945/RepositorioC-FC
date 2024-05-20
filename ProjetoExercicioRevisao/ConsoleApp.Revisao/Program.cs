#region Ex 1
using ConsoleApp.Revisao.Classes;

Restaurante restaurante = new Restaurante();

        // restaurante.AdicionarPedido(1, new Pedido("Hamburger", 2, 28.99));
        // restaurante.AdicionarPedido(1, new Pedido("Coca-Cola", 2, 5.50));
        // restaurante.AdicionarPedido(2, new Pedido("Pizza Mussarela Grande", 1, 59));

        // Console.WriteLine("Total da Mesa 1: $" + restaurante.CalcularTotalMesa(1));
        // restaurante.ModificarPedido(1, 0, new Pedido("Cheeseburger", 2, 39.49));
        // Console.WriteLine("Total da Mesa 1 após modificação: $" + restaurante.CalcularTotalMesa(1));

        #endregion

        #region Ex 2
      
    //     Cozinha cozinha = new Cozinha();

    //     var pedido1 = new Pedido("Hamburger", 2, 8.99);
    //     var pedido2 = new Pedido("Pizza", 1, 12.75);

    //    // Mesa(99) = Delivery
    //     restaurante.AdicionarPedido(99, new Pedido("Barca de Sushi", 1, 168.99));
    //     restaurante.AdicionarPedido(99, new Pedido("Hot Dog 60cm", 2, 50));

    //     cozinha.AdicionarPedidoNaFila(pedido1);
    //     cozinha.AdicionarPedidoNaFila(pedido2);

    //     cozinha.ProcessarPedido();
    //     cozinha.ProcessarPedido();

    //     cozinha.EntregarPedido();
    //     cozinha.EntregarPedido();

        #endregion

        #region Ex 3

        // Cria uma instância do sistema de análise de vendas
        SistemaDeAnaliseDeVendas sistema = new SistemaDeAnaliseDeVendas();

        // Populando a lista de produtos
        sistema.produtos.Add(new Produto { IdProduto = 1, NomeProduto = "Café", Categoria = "Bebidas", PrecoProduo = 2.50 });
        sistema.produtos.Add(new Produto { IdProduto = 2, NomeProduto = "Chá", Categoria = "Bebidas", PrecoProduo = 1.50 });
        sistema.produtos.Add(new Produto { IdProduto = 3, NomeProduto = "Bolo de Chocolate", Categoria = "Sobremesas", PrecoProduo = 3.00 });
        sistema.produtos.Add(new Produto { IdProduto = 4, NomeProduto = "Suco de Laranja", Categoria = "Bebidas", PrecoProduo = 3.00 });
        sistema.produtos.Add(new Produto { IdProduto = 5, NomeProduto = "Torta de Limão", Categoria = "Sobremesas", PrecoProduo = 2.75 });

        // Populando a lista de vendas
        sistema.vendas.Add(new Venda { ProdutoId = 1, QuantidadeVendida = 10, DataVenda = new DateTime(2024, 5, 1) });
        sistema.vendas.Add(new Venda { ProdutoId = 1, QuantidadeVendida = 5,  DataVenda = new DateTime(2024, 5, 2) });
        sistema.vendas.Add(new Venda { ProdutoId = 2, QuantidadeVendida = 7,  DataVenda = new DateTime(2024, 5, 1) });
        sistema.vendas.Add(new Venda { ProdutoId = 3, QuantidadeVendida = 4,  DataVenda = new DateTime(2024, 5, 3) });
        sistema.vendas.Add(new Venda { ProdutoId = 4, QuantidadeVendida = 8,  DataVenda = new DateTime(2024, 5, 4) });
        sistema.vendas.Add(new Venda { ProdutoId = 5, QuantidadeVendida = 6,  DataVenda = new DateTime(2024, 5, 1) });

        // Chamando os métodos de análise
        Console.WriteLine("Produtos Vendidos:");
        sistema.ListarProdutosVendidos();

        Console.WriteLine("Produtos Mais Vendidos:");
        sistema.ListarProdutosMaisVendidos();

        Console.WriteLine("Vendas Por Categoria:");
        sistema.ListarVendasPorCategoria();

        Console.WriteLine("Filtrar Vendas por Data (1º de Maio de 2024 a 3 de Maio de 2024):");
        sistema.FiltrarVendasPorData(new DateTime(2024, 5, 1), new DateTime(2024, 5, 3));
        #endregion