// ЗАДАНИЕ 7:Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

//Способ 1

Console.WriteLine("Введите число из отрезка [10,99]:");
int number = Int32.Parse(Console.ReadLine()??"");
int numberA = number % 10;
int numberB = number / 10;

if(numberA > numberB) Console.WriteLine("наибольшая цифра = " + numberA);

if(numberA == numberB) Console.WriteLine("наибольшей цифры нет");

if(numberA < numberB) Console.WriteLine("наибольшая цифра = " + numberB);




//Способ 2

//int number = new Random().Next(9,100);
//Console.WriteLine(number);
//int numberA = number % 10;
//int numberB = number / 10;
//if(numberA > numberB) Console.WriteLine("наибольшая цифра = " + numberA);
//if(numberA == numberB) Console.WriteLine("наибольшей цифры нет");
//if(numberA < numberB) Console.WriteLine("наибольшая цифра = " + numberB);

