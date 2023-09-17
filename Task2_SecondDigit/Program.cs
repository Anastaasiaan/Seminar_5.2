/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98 */

int DelSecondDig(int number)
{
    int firstDig = number / 100;
    int secondDig = number % 10;

    int result = firstDig * 10 + secondDig;
    return result;
}

int randNumd = new Random().Next(100, 1000);
System.Console.WriteLine($"{randNumd} - > {DelSecondDig(randNumd)}");
