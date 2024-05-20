using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleApp.Lista.Exercicio
{
    public class GerenciadorDeTickets
    {
        public Queue<Ticket> filaAlta = new Queue<Ticket>();

        public Queue<Ticket> filaMedia = new Queue<Ticket>();
        
        public Queue<Ticket> filaBaixa = new Queue<Ticket>();

        
        void AdicionarTicket( Ticket ticket )
        {   
            if(filaAlta.Count > 0){

                filaAlta.Enqueue(ticket);
            }

        }

        void ResolverTicket()
        {
            

        }

        void ImprimirTickets()
        {

            
        }

    }

}