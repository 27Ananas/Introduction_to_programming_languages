// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());

void PalindromCheck(int number)
{
    if (number >= 10000)
    {
        int a1 = number / 10000;
        int b1 = number % 10;

        if (a1 == b1)
        {
            number = number / 10;
            int a2 = (number / 100) % 10;
            int b2 = number % 10;
            if (a2 == b2)
                Console.WriteLine("Да");
        }
        else
            Console.WriteLine("Нет");
    }
    else
        Console.WriteLine("Некорректное число");
}

PalindromCheck(number);