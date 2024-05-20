// See https://aka.ms/new-console-template for more information


using ConsoleApp1;

Lampada MinhaLampada = new();

MinhaLampada.Estado = true;
MinhaLampada.Intensidade = 20;

System.Console.WriteLine(MinhaLampada.AjusteIntensidade());
System.Console.WriteLine(MinhaLampada.LigarDesligar());

