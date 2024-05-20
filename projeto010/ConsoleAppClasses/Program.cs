

using ConsoleAppClasses;

Motocicleta moto = new Motocicleta("Suzuki", "Boulevard", 2011, 800);
// moto.NovoMarca();
moto.NovoMarca("honda");
Console.WriteLine(moto.marca);

// moto.novaCilindrada();
// moto.AnoFabricado();
// Console.WriteLine($"{moto.NovoMarca} + {moto.modeloMoto} + {moto.anoMoto} + {moto.novaCilindrada}");
