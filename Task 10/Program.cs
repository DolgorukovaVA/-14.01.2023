﻿// ЗАДАНИЕ 10: Найти третью цифру числа или сообщить, что её нет
//КОД не РАБОТАЕТ !! ЗАДАНИЕ не РЕШЕНО, это лишь ПОПЫТКИ.

//Console.WriteLine("Введите число:");

//int Number = new Random().Next(1, 1000);
//Console.WriteLine();
//Console.WriteLine($"Дано число: {Number}");

//if (Number / 100 > 0) Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 10 % 10}");
//else Console.WriteLine($"У числа {Number} нет третьей цифры");

Console.WriteLine("Введите число:");

int Number = int.Parse(Console.ReadLine());
int NewNumber = 0;
if(Number < 100) Console.WriteLine($"У числа {Number} нет третьей цифры");
if(Number > 99 && Number < 1000) Console.WriteLine($"Третьей цифрой числа является {Number % 10}");
else
{
     while(Number > 999)
    {
     NewNumber = (Number/10);
     //NewNumber = Number;// return NewNumber;
    }
     Console.WriteLine($"Третьей цифрой числа {Number} является цифра {NewNumber % 10}");
}

