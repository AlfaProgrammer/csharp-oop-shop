// See https://aka.ms/new-console-template for more information

using csharp_oop_shop.Shop;

Product prod1 = new Product("HP Laptop", "Bellissimo", 1252.26);
Console.WriteLine($"prod1 code: {prod1.Code}");
Product prod2 = new Product("Mac Book", "Fantastico", 2152.99);
Console.WriteLine($"prod2 code: {prod2.Code}");
Product prod3 = new Product("Pera Book", "Deforme", 999.86);
Console.WriteLine($"prod3 code: {prod3.Code}");

Console.WriteLine();

Console.WriteLine("TEST TUTTI I METHODS");
Console.WriteLine($"{prod2.Price} EUR");
Console.WriteLine($"prod2 prezzoiva: {prod2.getPriceWithVat()} EUR");
Console.WriteLine($"stato dell'index dopo la creazione dell'ultima istanza: {Product.CodeIndex}");

/*
Console.WriteLine(prod1.name);
Console.WriteLine(prod1.description);
Console.WriteLine(prod1.Price);
Console.WriteLine(prod1.Iva); */