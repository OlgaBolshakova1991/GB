//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. решить без массива

//c массивом
/*
int[] CreateArray(int size)
{
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
        Console.Write (array[i] + "   ");
        Console.WriteLine();
}

int QuantitiPositiveNum(int[] array)
{
   int quant = 0;
   for (int i = 0; i < array.Length; i++ )
    {
        if(array[i] > 0) quant++;
    }
    
return quant;
}

Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите числа:  ");
int [] myArray = CreateArray(size);
ShowArray (myArray);
int quant = QuantitiPositiveNum(myArray);
Console.WriteLine();
Console.WriteLine($"Количество введенных положительных чисел равно {quant}. ");  
Console.WriteLine();
*/

//без массива
/*

int QuantitiPositiveNum(int num)
{
    int current = 0;
    int n = 1;
    while(n <= num)
    {
        Console.Write($"Введите {n} число: ");
        num = Convert.ToInt32(Console.ReadLine());

        if(num > 0) 
        {
            current++;
            n++;
        }
    //n++;
    }
return current;
}

Console.WriteLine("Введите количество чисел: ");
int cur = Convert.ToInt32(Console.ReadLine());

int quant = QuantitiPositiveNum(cur);
Console.WriteLine($"Введено {quant} чисел больше нуля");  
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.




void IntersectPoint(double b1, double b2, double k1, double k2)
{
    double x = (b1 - b2)/(k1 - k2);;
    double y = k1 * (b1 - b2/k1 - k2) + b1;

    if(k1 == k2 && b1 == b2) Console.WriteLine("Данные прямые совпадают");
    else
         if(k1 == k2) Console.WriteLine("Данные прямые параллельны");
            else Console.WriteLine($"Данные прямые пересекаются в точке {x}, {y} ");
}


Console.WriteLine("Введите число k1 :");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2 :");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b1 :");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b2 :");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
IntersectPoint(b1, b2, k1, k2);
