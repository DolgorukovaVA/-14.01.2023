// ЗАДАНИЕ 4: Показать четные числа от 1 до N
Console.Write("Введите число:   ");
int endNum = Convert.ToInt32(Console.ReadLine());
int num = 0;
Console.WriteLine($"Чётные числа из диапазона от 1 до {endNum}:");
while (num < endNum)
{
    num++;
    if ((num % 2) == 0) Console.Write($"{num} ");
}
Console.WriteLine();