/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]

1. Метод, который принимает 8 чисел и создает из них массив
2. Метод, который печатает массив
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

int[] EnteringAnArrayOf8Numbers() // метод который принимает из консоли 8 чисел и создает из них массив
{
    Console.WriteLine("Введите массив из 8 чисел: ");
    int number1 = GetIntNumber();
    int number2 = GetIntNumber();
    int number3 = GetIntNumber();
    int number4 = GetIntNumber();
    int number5 = GetIntNumber();
    int number6 = GetIntNumber();
    int number7 = GetIntNumber();
    int number8 = GetIntNumber();
    
    int[] array = { number1, number2, number3, number4, number5, number6, number7, number8 };
    return array;
}

void PrintArray(int[] array) // метод который выводит на печать массив
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

int[] array = EnteringAnArrayOf8Numbers();
Console.Write($"Вы задали массив -> ");
PrintArray(array);