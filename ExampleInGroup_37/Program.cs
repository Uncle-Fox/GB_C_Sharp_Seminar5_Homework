/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] ProductOfNumbers(int[] array)
{
    int sum = array.Length / 2;
    if (array.Length % 2 == 0) sum += 1;
    int[] arrNew = new int[sum];

    for (int i = 0; i < array.Length/2; i++)
    {
        arrNew[i] = array[i] * array[array.Length-1-i];
    }
    if (array.Length % 2 != 0) arrNew[arrNew.Length - 1] = array[array.Length/2];

    return arrNew;
}


int[] array = CreateArrayRndInt(5, -5, 5);
Console.Write("[");
PrintArray(array);
Console.Write("]");

int[] result = ProductOfNumbers(array);
Console.Write(" -> ");
PrintArray(result);
