// See https://aka.ms/new-console-template for more information

  Contador meuContador = new Contador(0,false);

    // Incremnta o valor do contador três vezes
    meuContador.Incrementar();
    meuContador.Incrementar();
    meuContador.Incrementar();

    // Decrementa o valor do contador uma vez
    meuContador.Decrementar();

    // Imprime no console o valor final do contador
    System.Console.WriteLine($"Valor final do contador: {meuContador.valor}");
