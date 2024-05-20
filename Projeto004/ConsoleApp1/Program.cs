// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Termometro TermometroCasa = new();

TermometroCasa.AjustarTemperatura(26.5);
System.Console.WriteLine(TermometroCasa.MostrarTemperatura());
