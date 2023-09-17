// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int InputNum(string message)
{
Console.Write(message);
int num = int.Parse(Console.ReadLine()!);
return num;
}

void IsSquare(int a, int b)
{
    if (a * a == b)
{
    System.Console.WriteLine("Да");
}
    else
{
    System.Console.WriteLine("Нет");
}
}

int num1 = InputNum("Введите первое число: ");
int num2 = InputNum("Введите второе число: ");

IsSquare(num1, num2);
