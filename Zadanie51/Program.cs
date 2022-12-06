/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int Promt(String message)//Приглашение ко ввод
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int countDiv = 0;

int DivTwo(int[] array) //Проверка на чётнось чисел в массиве
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countDiv++;
        }
    }
    return countDiv;
}

int[] InputArray(int Length)//Заполнение массива
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)//Вывод массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Length0 = Promt("Введите размер массива ");

int[] arr1 = InputArray(Length0);
PrintArray(arr1);
DivTwo(arr1);
System.Console.WriteLine($"Количество четных чисел в массиве равно {countDiv}");