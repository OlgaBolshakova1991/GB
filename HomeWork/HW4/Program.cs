// Задача. Написать цикл, который принимает на вход два числа (а и в) и возводит число а в натуральную степень в.


// int FindExp(int a, int b)
// {
//     int exp = 1;
    
//     for(int current = 1; current <= b; current ++)
//         exp = exp * a;

//     return exp;
// }
//     Console.WriteLine("Введите число А: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число В: ");
//     int b = Convert.ToInt32(Console.ReadLine());


// int result = FindExp(a, b);
// Console.WriteLine($"Результат возведения числа A в степень B равен {result}");




//==========================================================================================

// Задача. Написать программу, которая принимает на вход число и выдает сумму цифр в числе.


// int FindSumDigit(int number)
// {
// 	int sum = 0;

// 	while(number > 0)
// 	{
// 		sum = sum + number % 10;
// 		number = number / 10;
// 	}
// 	return sum;

// }
	
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sumDigit = FindSumDigit(num);
// Console.Write($"Сумма цифр в числе {num} равна {sumDigit}.");


//===========================================================================================


//Задача. Написать программу, которая задает массив из n элементов и выводит его на экран. (Размер и элементы массива задает пользователь)

// int[] CreateRandomArray(int size)
//  {
//      int[] newArray = new int [size];
	 

//      for(int i = 0; i < size; i ++)
// 	{
// 		Console.Write($"Введите {i} элемент массива: " );
// 		newArray[i]= Convert.ToInt32(Console.ReadLine());
// 	}
		
//     return newArray; 
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i ++)
		
//         Console.Write(array[i] + " ");
//         Console.WriteLine();
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());



// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);