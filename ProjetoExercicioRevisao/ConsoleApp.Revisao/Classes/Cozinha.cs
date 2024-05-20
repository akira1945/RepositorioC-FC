using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace ConsoleApp.Revisao.Classes
{
    public class Cozinha
    {
        public Queue<Pedido> filaDePedidos {get; set;}

        public Stack<Pedido> pilhaDePedidos {get; set;}

        public Cozinha()
        {
            filaDePedidos = new Queue<Pedido>();

            pilhaDePedidos= new Stack<Pedido>();
        }

        public void AdicionarPedidoNaFila(Pedido pedido)
        {
            filaDePedidos.Enqueue(pedido);
        }

        public void ProcessarPedido()
        {
            if(filaDePedidos.Count >0 )
            {
                var pedido = filaDePedidos.Dequeue();
                pedido.Preparar();
                pilhaDePedidos.Push(pedido);
            }
            else
            {
                Console.WriteLine("Sem pedidos para processar.");
            }
        }

        public void EntregarPedido()
        {
            if(filaDePedidos.Count >0 )
            {
                var pedido = pilhaDePedidos.Pop();
                Console.WriteLine($"Entregando: {pedido.Item} - {pedido.Quantidade}");
            }
            else
            {
                System.Console.WriteLine("Sem pedidos para entrega.");
            }

        }



    }
}