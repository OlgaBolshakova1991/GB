//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


// int[] CreateRandomArray(int size)
//  {
//      int[] newArray = new int [size];
//      for(int i = 0; i < size; i++)
//          newArray[i] = new Random().Next(size);
//     return newArray; 
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i ++)
//         Console.Write(array[i] + " ");
//         Console.WriteLine();
// }

// int FindSum (int[] array)
// {

//     int sum = 0;
//     for(int i = 1; i < array.Length; i += 2)
//         sum = sum + array[i];
    
//     return sum;
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);
// int sum = FindSum(myArray);
// Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях, равна {sum}");


//====================================================================================================================================



//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
//  {
//      int[] newArray = new int [size];
//      for(int i = 0; i < size; i++)
//          newArray[i] = new Random().Next(minValue, maxValue + 1);
//     return newArray; 
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//         Console.WriteLine();
// }

// int FindEvenNum(int[] array) 
// {
//     int count = 0;
    
//     for(int i = 0; i < array.Length; i ++)
//     {
        
//          if(array[i] % 2 == 0) count ++;
           
    
//     }
//     return count;
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size,100,1000);
// ShowArray(myArray);

// int evenNum = FindEvenNum(myArray);
// Console.WriteLine($"Количество четных элементов равно: {evenNum}");



//====================================================================================================================================



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.


// double[] CreateRandomArray(int size)
//  {
//      double[] newArray = new double[size];
//      for(int i = 0; i < size; i++)
//     {
//         newArray[i] = Math.Round((new Random().Next(size) + new Random().NextDouble()), 2);
//     }
//     return newArray;
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i ++)
//         Console.Write (array[i] + "   ");
//         Console.WriteLine();
// }


// double DiffMaxMin(double[] array) 
// {
//     double min = array[0];
//     double max = array[0];
   
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] < min)  min = array[i];
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] > max)  max = array[i];
        
    
//     Console.WriteLine($"Max = {max} ");
//     Console.WriteLine($"Min = {min} ");
//     return Math.Round((max - min), 2);
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = CreateRandomArray(size);
// ShowArray(array);
// double diff = DiffMaxMin(array);
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diff}");
