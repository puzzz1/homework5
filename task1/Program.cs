/*Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


int[] GenerateRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");

}

int FindNumberInArray(int[] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
           index = index + array[i];
        }
    }
    return index;
}
Console.Write("В этом массиве - ");
int[] array = GenerateRandomArray(5, -10, 10);
printArray(array);

int index = FindNumberInArray(array);
Console.WriteLine($" -  {index} сумма нечетных элементов");