using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("iPhone");
Smartphone iphone = new Iphone("3785", "Modelo bom", "87624643909", 64);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Playstore");

Console.WriteLine("\nSmartphone Nokia");
Smartphone nokia = new Nokia("7834", "Modelo melhor", "88392135002", 256);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Free fire");
nokia.Ligar();