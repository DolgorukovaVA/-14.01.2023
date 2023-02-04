// ЗАДАНИЕ 9: Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите первое число:");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int Number2 = Convert.ToInt32(Console.ReadLine());

if(Number1 % Number2 == 0) Console.WriteLine($"Число {Number1} кратно числу {Number2}");

else
{
    Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток от деления равен {Number1 % Number2}");
}
Console.WriteLine();
