
// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
// Пример:
//  2,  3 => 1
// -5,  3 => 2
// -3, -2 => 3
//  4, -2 => 4

System.Console.WriteLine("Введите координаты точки X: ");
int xNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки Y: ");
int yNumber = Convert.ToInt32(Console.ReadLine());

if (xNumber != 0 && yNumber != 0)
{
    if (xNumber > 0 && yNumber > 0)
    {
        System.Console.WriteLine($"{xNumber}, {yNumber} => 1");
    }
    else if (xNumber < 0 && yNumber > 0)
    {
        System.Console.WriteLine($"{xNumber}, {yNumber} => 2");
    }
    else if (xNumber < 0 && yNumber < 0)
    {
        System.Console.WriteLine($"{xNumber}, {yNumber} => 3");
    }
    else if (xNumber > 0 && yNumber < 0)
    {
        System.Console.WriteLine($"{xNumber}, {yNumber} => 4");
    }
}
else
{
    System.Console.WriteLine("Координаты X и Y не должны быть равными 0!!!");
}

