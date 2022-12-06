/*Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 6] -> 0*/

int Promt(String message)//Приглашение ко вводу
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int sum = 0;

int DivTwoiPos(int[] array)//Вычисление суммы элементов на нечетных позициях (если считать пзиция массива - 1 2 3 и т.д.)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (i%2 == 0)
       {
          sum = sum + array[i] ;
       }
    }
    return sum;
}

int[] InputArray(int Length)//Заполнение массива
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
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

int Length0 = Promt("Введите размер массива  ");
/*int minRange = Promt("Vvedite minimum zhachenie ");
int maxRange = Promt("Vvedite max zhachenie ");*/

int[] arr1 = InputArray(Length0);
PrintArray(arr1);
DivTwoiPos(arr1);
System.Console.WriteLine($"Сумма чисел стоящих на нечетных позициях в массиве равна {sum}");