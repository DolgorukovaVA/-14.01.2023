// Задание 2: По заданному номеру дня недели вывести его название

Console.WriteLine("Введите число:");
int day = int.Parse (Console.ReadLine());
switch (day)
{
    case 1: Console.WriteLine("Monday"); break;
    case 2: Console.WriteLine("Tuesday"); break;
    case 3: Console.WriteLine("Wednesday"); break;
    case 4: Console.WriteLine("Thursday"); break;
    case 5: Console.WriteLine("Friday"); break;
    case 6: Console.WriteLine("Saturday"); break;
    case 7: Console.WriteLine("Sunday"); break;
}
if (day == 6 || day == 7) Console.WriteLine("Weekend");
else Console.WriteLine("Workday");