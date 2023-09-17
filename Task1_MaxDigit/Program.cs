/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.*/

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = new Random().Next(10, 100); // [a, b)
int res = MaxDigit(number);
Console.WriteLine($"В числе {number} максимальная цифра {res}");