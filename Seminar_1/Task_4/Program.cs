// Вывести четные числа от одного до N
// int count=2
Console.WriteLine("input namber >= 2: ");
int namber = Convert.ToInt32(Console.ReadLine());
int count=2;
while (count <= namber)
{
    Console.Write(count + ", ");
    count = count+2;
}