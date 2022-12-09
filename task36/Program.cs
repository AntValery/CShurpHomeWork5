/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] createArray()
{
    int n = new Random().Next(2, 10);
    int[] array = new int[n];
    for(int i = 0; i < n; i++){
        array[i] = new Random().Next(-100, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

    return array;
}

int printCountOddEllements(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++){
        if((i % 2) == 0) n++;
    }
    return n;
}

int[] array = createArray();
Console.WriteLine(printCountOddEllements(array));