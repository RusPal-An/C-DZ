Console.Clear();

Console.Write("Введите  число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a < b)
    Console.WriteLine($"Число {a} - min. {b} - max");
else Console.WriteLine($"Число {a} - max. {b} - min");    