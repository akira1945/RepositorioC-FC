using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Revisao.Classes
{
    public class Restaurante
    {
       public List<Pedido> pedidos {get; set;}

       public Dictionary<int, List<Pedido>> PedidosPorMesa{get; set;}
        internal static int mesa;

        public Restaurante()
       {
            pedidos = new List<Pedido>();
            PedidosPorMesa = new Dictionary<int, List<Pedido>>();
       }

    //metodos

        public void AdicionarPedido(int mesa, Pedido pedido)
        {
            pedidos.Add(pedido);

            if(!PedidosPorMesa.ContainsKey(mesa))
            {
                PedidosPorMesa[mesa] = new List<Pedido>();
            }

            PedidosPorMesa[mesa].Add(pedido);
        }

        public void ModificarPedido(int mesa, int indicePedido, Pedido novoPedido)
        {
            if(!PedidosPorMesa.ContainsKey(mesa))
            {
                pedidos[indicePedido] = novoPedido;
                if(!PedidosPorMesa.ContainsKey(mesa))
                {
                PedidosPorMesa[mesa][indicePedido] = novoPedido;
                }
            }
        }

        public double CalcularTotalMesa(int mesa)
        {
           double total = 0;
            if (PedidosPorMesa.ContainsKey(mesa))
            {
                //total = pedidosPorMesa[mesa].Sum(s => s.CalcularTotal());
                foreach (var pedido in PedidosPorMesa[mesa])
                {
                    total += pedido.CalcularTotal();
                }
            }
            return total;
        }

    }
}