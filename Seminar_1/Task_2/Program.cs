// Задача на вывод максимального числа из трех чисел
Console.WriteLine("input namber1: ");
int namber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input namber2: ");
int namber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input namber3: ");
int namber3 = Convert.ToInt32(Console.ReadLine());
int max = namber1;
if (namber2 > max) max = namber2;
if (namber3 > max) max = namber3;
Console.Write ("max= ");
Console.WriteLine (max);