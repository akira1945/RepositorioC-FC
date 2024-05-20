// using System.Collections;
// using System.Diagnostics;

// Console.WriteLine("Hello, World!");


// // Zera uma fila
// Queue<string> variavel = new Queue<string>();
// variavel.Enqueue("Nemesis");
// variavel.Enqueue("Maximos");
// variavel.Enqueue("Pedro Augusto");

// while (variavel.Count > 0){

// variavel.Dequeue();

// };

// //Tarefas executadas na mesma orderm

// Queue<Tarefas> tarefas = new  Queue<Tarefas>();


// // Fila de prioridades

// Queue<ProcessPriorityClass> atendimentoNormal = new Queue<ProcessPriorityClass>();
// Queue<ProcessPriorityClass> atendimentoPreferencial = new Queue<ProcessPriorityClass>();

// Instancia o gerenciador de tickets
using ConsoleApp.Lista.Exercicio;


	// Instancia o gerenciador de tickets
        GerenciadorDeTickets gerenciador = new GerenciadorDeTickets();

        // Adicionando alguns tickets ao sistema
        gerenciador.AdicionarTicket(new Ticket(1, "Falha no login", Prioridade.Alta));
        gerenciador.AdicionarTicket(new Ticket(2, "Erro ao carregar página", Prioridade.Media));
        gerenciador.AdicionarTicket(new Ticket(3, "Pedido de atualização de software", Prioridade.Baixa));
        gerenciador.AdicionarTicket(new Ticket(4, "Problema de performance no servidor", Prioridade.Alta));
        gerenciador.AdicionarTicket(new Ticket(5, "Erro no banco de dados", Prioridade.Media));

        // Exibindo tickets antes da resolução
        Console.WriteLine("Tickets antes da resolução:");
        gerenciador.ImprimirTickets();

        // Resolvendo tickets
        Console.WriteLine("Processo de resolução de tickets:");
        gerenciador.ResolverTicket();
        gerenciador.ResolverTicket();
        gerenciador.ResolverTicket();

        // Exibindo tickets após resolver alguns
        Console.WriteLine("Tickets após resolver alguns:");
        gerenciador.ImprimirTickets();

        // Continuar a resolver todos os tickets
        Console.WriteLine("Resolvendo todos os tickets restantes:");
        while (gerenciador.filaAlta.Count > 0 || gerenciador.filaMedia.Count > 0 || gerenciador.filaBaixa.Count > 0)
        {
            gerenciador.ResolverTicket();
        }

        // Verificando se todos os tickets foram resolvidos
        Console.WriteLine("Todos os tickets foram resolvidos:");
        gerenciador.ImprimirTickets();