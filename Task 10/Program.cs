// ЗАДАНИЕ 10: Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число:");

int Number = int.Parse(Console.ReadLine()??"");

if(Number < 100) Console.WriteLine($"У числа {Number} нет третьей цифры");
else
{
    while(Number > 999)
    {
      Number = (Number/10);
      if(Number > 99 && Number < 1000) Console.WriteLine($"Третьей цифрой числа является {Number % 10}");
    }
    Console.WriteLine($"Третьей цифрой числа является цифра {Number % 10}");
 }

