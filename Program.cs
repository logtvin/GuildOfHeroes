Hero yaroslav = new Hero("Ярослав", 100);
inventory backpack = new inventory("Рюкзак", 20, 8);
Hero anastasia = new Hero("Анастасия", 90);
inventory pockets = new inventory("карманы", 5, 0);
Hero artem = new Hero("Артём", 120);
inventory bag = new inventory("сумка", 10, 3);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");
Console.WriteLine(">>> инвентарь <<<");
Console.WriteLine($"тип: {backpack.types}");
Console.WriteLine($"вес: {backpack.Weight}");
Console.WriteLine($"прочность: {backpack.Durability}");
Console.WriteLine($"броня: {backpack.Armor}");


Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");
Console.WriteLine(">>> инвентарь <<<");
Console.WriteLine($"тип: {pockets.types}");
Console.WriteLine($"вес: {pockets.Weight}");
Console.WriteLine($"прочность: {pockets.Durability}");
Console.WriteLine($"броня: {pockets.Armor}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");
Console.WriteLine(">>> инвентарь <<<");
Console.WriteLine($"тип: {bag.types}");
Console.WriteLine($"вес: {bag.Weight}");
Console.WriteLine($"прочность: {bag.Durability}");
Console.WriteLine($"броня: {bag.Armor}");