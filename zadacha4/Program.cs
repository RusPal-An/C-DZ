Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());
if(a>b || b>c)
    Console.WriteLine($"{a} - максимальное число ");
else 
    Console.WriteLine($"{b} - максимальное число ");   
else(c>a || c>b);
    Console.WriteLine($"{c} - максимальное число ");  