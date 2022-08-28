//Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
/*

//1 вариант решения

int FindSecondDigit(int number)
{
    
    int dec = number % 100 / 10;

    return dec;

}

int randNumber = new Random ().Next(100, 1000);
int secondDigit = FindSecondDigit(randNumber);

Console.WriteLine($"Вторая цифра числа {randNumber} равна {secondDigit}");

*/

//2 вариант решения

void FindSecondDigit(int number)
{
    if(number >= 100 && number < 1000)
    {
        int dec = number % 100 / 10;

        Console.WriteLine($"Вторая цифра числа {number} равна {dec} ");
    }
    
    else

    {
        Console.WriteLine($"Ошибка. Введите трехзначное число ");
    }

        

    if(number <= (-100) && number > (-1000))
    {
        int dec = (number % 100 / 10) * (-1);
        Console.WriteLine($"Вторая цифра числа {number} равна {dec} ");
    }
    
}

Console.Write($"Введите число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
FindSecondDigit(secondDigit);




//Задача.Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
void FindThirdDigit(int number)

{
    int hund = number % 1000 / 100;

    if(number >= 100) Console.WriteLine($"Третьей цифрой в числе {number} является {hund}");
    if(number <= (-100)) 
    {
        hund = hund * (-1);
        Console.WriteLine($"Третьей цифрой в числе {number} является {hund}");
       
    }    
    
    if(number < 100 & number > (-100)) Console.WriteLine($"Третьей цифры в числе {number} нет");
        
        
}

Console.Write("Введите число: ");
 
int thirdDigit = Convert.ToInt32(Console.ReadLine());

FindThirdDigit(thirdDigit);
*/


 //Задача. Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
 void DayOfWeek(int number)

 {
    
    if(number == 1) Console.WriteLine("Понедельник");
    if(number == 2) Console.WriteLine("Вторник");
    if(number == 3) Console.WriteLine("Среда");
    if(number == 4) Console.WriteLine("Четверг");
    if(number == 5) Console.WriteLine("Пятница");
    if(number == 6) Console.WriteLine("Суббота - ВЫХОДНОЙ!");
    if(number == 7) Console.WriteLine("Воскресенье - ВЫХОДНОЙ");
    if(number > 7) Console.WriteLine("Ошибка. Введите число от 1 до 7");

 }

Console.WriteLine("Введите число:  ");
int weekDay = Convert.ToInt32(Console.ReadLine());
DayOfWeek(weekDay);

*/

