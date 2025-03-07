using Homework3;

Manager manager = new Manager(1, "Ayşe", 30000, "Software", 3);
Developer developer = new Developer(2, "Ali", 25000, "Software", "Junior");
manager.Info();
Console.WriteLine($"Prim: {manager.CalculateBonus()}\n");

developer.Info();
Console.WriteLine($"Prim: {developer.CalculateBonus()}");