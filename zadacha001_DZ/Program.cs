/*
Задача 25: Напишите программу, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16


1. Метод который принимает 2 числа, проверяет что бы они были целыми
2. Метод который возводит A в натуральную степень B
*/

int GetIntNumber() // метод который получает число с консоли и проверяет что бы оно было целым
{
    bool needFalse = true;
    int result = 0;
    while (needFalse)
    {
        string numberFromConsole = Console.ReadLine();
        if (int.TryParse(numberFromConsole, out int trueNumber))
        {
            result = trueNumber;
            needFalse = false;
        }
        else Console.WriteLine("Ошибка! Вы ввели не верное число. Введите целое число:");
    }
    return result;
}

double Exponentiation(int A, int B) // Метод который возводит A в натуральную степень B
{
    double result = Math.Pow(A, B);
    return result;
}

Console.WriteLine("Возведение A в степень B.");
Console.WriteLine("Введите целое число А:");
int numberA = GetIntNumber();
Console.WriteLine("Введите целое число B:");
int numberB = GetIntNumber();
Console.WriteLine($"Ответ: {numberA} в {numberB} степени = {Exponentiation(numberA,numberB)}");