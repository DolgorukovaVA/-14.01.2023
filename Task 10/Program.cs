﻿// ЗАДАНИЕ 10: Найти третью цифру числа или сообщить, что её нет

//Console.WriteLine("Введите число:");

int Number = new Random().Next(1, 1500);
Console.WriteLine();
Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0) Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 10 % 10}");
else System.Console.WriteLine($"У числа {Number} нет третьей цифры");