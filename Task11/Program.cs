// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Трёхзначное число -> {number}");

int res = RemoveSecondDgigit(number);
Console.WriteLine($"Ваше число -> {res}");

int RemoveSecondDgigit(int num)
{
    int num1 = num / 100;
    int num3 = num % 10;
    int result1 = num1 * 10 + num3;
    return result1;
}