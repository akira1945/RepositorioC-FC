using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Revisao.Classes
{
    public class SistemaDeAnaliseDeVendas
    {
        public List<Produto> produtos;

        public List<Venda> vendas;

        public object QuantidadeVendida { get; private set; }

        public SistemaDeAnaliseDeVendas()
        {
            produtos = new List<Produto>();

            vendas = new List<Venda>();
        }


        public void ListarProdutosVendidos()
        {
            var produtosVedidos = vendas.Select( vendas => vendas.ProdutoId)
                                        .Distinct()
                                        .ToList();
            foreach (var itemVendido in produtosVedidos)
            {
                var resultadoVendido = produtos.FirstOrDefault(p => p.IdProduto == itemVendido);
                System.Console.WriteLine(value: $"Produto: {resultadoVendido.NomeProduto}");
            }

        }

        public void ListarProdutosMaisVendidos()
        {
            var produtosMaisVendidos = vendas.GroupBy(v => v.ProdutoId)
                                             .Select( g => new {ProdutoId = g.Key, Quantidade = g.Sum(v => v.QuantidadeVendida)})
                                             .OrderByDescending( r => r.Quantidade)
                                             .ToList();

            foreach (var itemMaisVendidos in produtosMaisVendidos)
            {
                var produto = produtos.FirstOrDefault(p=> p.IdProduto == itemMaisVendidos.ProdutoId);
                System.Console.WriteLine($"Produto: {produto.NomeProduto}, {itemMaisVendidos.Quantidade}");
            }

        }

        public void ListarVendasPorCategoria()
        {
            var produtosPorCategoria = vendas.Where(v => produtos.Any(p => v.ProdutoId == p.IdProduto))
                                            .GroupBy(v => v.ProdutoId)
                                               .Select( group => new{
                                                                QuantidadeVendida = group.Key, 
                                                                ProdutoId = group.OrderByDescending(h => h.ProdutoId ).ToList()}
                                                    ).ToList();

            foreach (var itemPorCategoria in produtosPorCategoria)
            {
                var produto = vendas.FirstOrDefault( v => v.ProdutoId == itemPorCategoria.ProdutoId )
                {
                    System.Console.WriteLine($"Porduto : {produto.Categoria} / {itemPorCategoria.QuantidadeVendida } ");
                }
            }
        }

        public void FiltrarVendasPorData(DateTime inicio, DateTime fim) 
        {
            var produtosVedidosPorData = vendas.Where(v => v.DataVenda >= inicio && v.DataVenda <= fim ).ToList();
            foreach (var itemPorData in produtosVedidosPorData)
            {
                var produto = produtos.FirstOrDefault(p => p.IdProduto == itemPorData.ProdutoId)
                {
                    System.Console.WriteLine($"Data: {itemPorData.DataVenda.ToString()}, Produto: {produto.NomeProduto}, Quantidade: {QuantidadeVendida}");
                }

            }

        }
    }
}