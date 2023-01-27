// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void Multiplicity(int arg1, int arg2)
// {
//     if (arg1 % arg2 == 0)
//         Console.WriteLine("Число " + arg1 + " кратно " + arg2);
//     else
//         Console.WriteLine("Число " + arg1 + " не кратно " + arg2 + ", остаток = " + arg1 % arg2);
// }
// Multiplicity(numOne, numTwo);

Console.Write("Введите первое число 1: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число 2: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

int remains = Remains(numOne, numTwo);
Console.WriteLine("кратно");

int Remains(int number1, int number2)
{
    return number1 % number2;
}

Console.WriteLine($"не кратно, остаток {remains}");
