// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23
// Пример:
// a=50 => нет
// a=7 => нет
// a=322 => да

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0 && number > 0)
{
    System.Console.WriteLine($"a={number} => Да");
}
else
{
    System.Console.WriteLine($"a={number} => Нет");
}

