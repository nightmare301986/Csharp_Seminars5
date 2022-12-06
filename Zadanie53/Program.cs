/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
int Promt(String message) //Приглашение ко вводу
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[] InputArray(int length,  int minch, int maxch) //Заполнение массива с учетом возможных верхней и нижней границы значений
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().Next(minch, maxch) * (new Random().NextDouble()))/1.1, 2); //Формула заполнения массива числами (2-мя знаками после запятой)
    }
    return array;
}

double razn = 0.00;

double MinMax(double[] array) //Нахождение минимального и максимального значения в массиве и разницы между ними
{
    double min = double.MaxValue;
    double max = double.MinValue;
    double razn = 0.00;

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }

    }
    max = Math.Abs(max); //значение по модулю максимума в массиве
    min = Math.Abs(min); //значение по модулю минимума в массиве
    razn = Math.Abs(max - min); //разница по модулю между минимальным и максимальным значениями в массиве
    return razn;
}

void PrintArray(double[] array)//Вывод массива на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write("{0} ", array[i].ToString("F02"));
        
    }
    Console.WriteLine();
}
int length0 = Promt("Введите размер массива  ");
int minch = Promt("Введите минимальное возможное число в массиве (-/+)  ");
int maxch = Promt("Введите максимальное возможное число в массиве (-/+) ");


double[] arr1 = InputArray(length0, minch, maxch);

PrintArray(arr1);
razn = Math.Round(MinMax(arr1),2);//Выполнение вычитания максимума и минимума с точностью 2-х знаков после запятой

System.Console.WriteLine($"Если вычесть из максимального элемента минимальный в массиве(см.выше), то результат (по модулю) будет равен: {razn}");