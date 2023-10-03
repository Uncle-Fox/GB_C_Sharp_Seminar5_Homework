/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2}, ");
        else Console.Write($"{arr[i]:F2}");
    }
}

double DifferenceBtwnMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        else if(array[i] > max) max = array[i];
    }
    Console.WriteLine($" {max:F2} и {min:F2}");
    return max - min;
}

double[] array = CreateArrayRndInt(5, -50, 100);
Console.Write("[");
PrintArray(array);
Console.Write("]");

double result = DifferenceBtwnMaxMin(array);
Console.Write(" -> ");
Console.Write($"{result:F2}");