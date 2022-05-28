/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

1. Принимаем на вход число
2. Пишем метод который считает сумму всех цифр этого числа
*/

int SumOfDigits(int num)
{
    int result = 0;
    string numToString = num.ToString();
    for (int i = 0; i < numToString.Length; i++)
    {
        result = result + int.Parse(numToString[i].ToString());
    }
    return result;
}

Console.WriteLine("Введите число и программа посчитает сумму цифр этого числа: ");
int number = int.Parse(Console.ReadLine());
int sum = SumOfDigits(number);
Console.WriteLine($"Сумма цифр числа {number} = {sum}");