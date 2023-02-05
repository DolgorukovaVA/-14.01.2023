// ЗАДАНИЕ 10: Найти третью цифру числа или сообщить, что её нет
//КОД не РАБОТАЕТ !! ЗАДАНИЕ не РЕШЕНО, это лишь ПОПЫТКИ.

//Console.WriteLine("Введите число:");

//int Number = new Random().Next(1, 1000);
//Console.WriteLine();
//Console.WriteLine($"Дано число: {Number}");

//if (Number / 100 > 0) Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 10 % 10}");
//else Console.WriteLine($"У числа {Number} нет третьей цифры");


Console.WriteLine("Введите число:");

int Number = Int.Parse(Console.ReadLine());
int NewNumber = 0;

if(Number < 100) Console.WriteLine($"У числа {Number} нет третьей цифры");

while (Number > 999)
{
     Number = (Number/10);
     NewNumber= number;
     return NewNumber;
}
Console.WriteLine($"Третьей цифрой числа {Number} является цифра {NewNumber % 10}");
