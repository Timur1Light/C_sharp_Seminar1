// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7


System.Console.WriteLine("Введите целое число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9 && number < 100)
{
    int num1 = number % 10;
    int num2 = number / 10;
    if (num1 > num2)
    {
        System.Console.WriteLine($"{number} => {num1}");
    }
    else
    {
        System.Console.WriteLine($"{number} => {num2}");
    }

}
else
{
    System.Console.WriteLine("Введенное чило не входит в отрезок [10, 99]");
}