//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
 int[,] CreateRandom2dArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(' ');
        }
        Console.WriteLine();
    }
}

void SortRows(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
}

Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = CreateRandom2dArray(row, column, minValue, maxValue);
Show2dArray(array);
Console.WriteLine();
SortRows(array);
Show2dArray(array);

*/




 //Задача 56:Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] CreateRandom2Array()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    return newArray;
}

void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMinSum(int[,] array) 
{
    int row = 0;
    int min = 0; 

    for(int j = 0; j < array.GetLength(1); j++)
        min = array[0, j] + min;   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
            sum = array[i,j] + sum;
    if(sum < min)
    {
        min = sum;
        row = i;
    }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {row + 1}");
    Console.WriteLine();
}
int[,] myArray = CreateRandom2Array();
ShowArray2(myArray);
FindMinSum(myArray);


*/


 //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}

void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultipliOfMatrix(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
        for(int j = 0; j < array1.GetLength(1); j++)
            for(int k = 0; k < array1.GetLength(1); k++)
            {
                    newArray[i,j] += array1[i,k] * array2[k,j];
            }
            
            return newArray;
}
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray1 = CreateRandom2Array(m, n, min, max);
ShowArray2(myArray1);
int[,] myArray2 = CreateRandom2Array(m, n, min, max);
ShowArray2(myArray2);
ShowArray2(MultipliOfMatrix(myArray1, myArray2));


*/



// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*

int[,,] CreateRandom3dArray(int row, int column, int plane)
{
    int[,,] array = new int[row, column, plane];
    
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
        {
            int k = 0;
            while(k < plane)
            {
                int number = new Random().Next(10, 100);
                if(FindNumber(array, number)) continue;
                array[i, j, k] = number;
                k++;
            }
        }
    return array;
}

bool FindNumber(int[,,] array, int number)
{
    bool findNumber = false;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i, j, k] == number)
                    findNumber = true;
            }
    return findNumber;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        
    }
}

Console.Write("Введите длину массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту: ");
int plane = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array = CreateRandom3dArray(row, column, plane);
Show3dArray(array);

*/






//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*

int[,] CreateRandom2Array()
{
    Console.WriteLine("Заполняем спирально КВАДРАТНЫЙ массив.");
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов равно количеству строк ");
    int columns = Convert.ToInt32(Console.ReadLine());
    

    int[,] newArray = new int[rows, columns];
    
    int step = 1;
    int i = 0;
    int j = 0;
    
    while (step <= newArray.GetLength(0) * newArray.GetLength(1))
    {
        newArray[i, j] = step;
        step++;
        if (i <= j + 1 && i + j < newArray.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= newArray.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > newArray.GetLength(1) - 1)
        j--;
        else
        i--;
    }

    ShowArray(newArray);

    return newArray;
}

CreateRandom2Array();

void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

*/