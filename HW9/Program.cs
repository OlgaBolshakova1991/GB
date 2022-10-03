// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumMN (int m, int n)
{
    if(m < n) ShowNumMN(m, n - 1);
        Console.Write(n + " ");
}
int numM = ;
int numN = 20;
ShowNumMN(numM,numN);

*/


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumElements(int m, int n)
{
    if(n < m)
    {
        if(m > n) return SumElements(m - 1, n) + m;
        return m;
    }
    else
    {        
        if(n > m) return SumElements(m, n - 1) + n;
        return n;
    }
}

Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Сумма элементов в промежутке от {firstNum} до {secondNum} равна {SumElements(firstNum, secondNum)}");
Console.WriteLine();

*/





// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int FunctionOfAkkerman(int m, int n)
{
    if(m == 0) return n + 1;
    if((m > 0) && (n == 0)) return FunctionOfAkkerman(m - 1, 1);
    if((m > 0) && (n > 0)) return FunctionOfAkkerman(m - 1, FunctionOfAkkerman(m, n - 1));
    else return n + 1;
}

Console.Write("Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат вычислений функции Аккермана чисел {numFirst} и {numSecond} равен {FunctionOfAkkerman(numFirst, numSecond)}");
Console.WriteLine();


*/
