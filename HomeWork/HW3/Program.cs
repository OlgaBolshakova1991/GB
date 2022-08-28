//Задача. Написать программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.





//Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*

double FindDistance(double x1, double x2, double y1, double y2, double z1, double z2)

{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

Console.WriteLine("Введите координаты первой точки: ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние мужду двумя точками равно {dist}");

*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int n)
{
    int i = 1;
    while(i <= n)
    {
        Console.WriteLine($"{Math.Pow(i, 3)}  ");
        i++;
    }
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);
*/

