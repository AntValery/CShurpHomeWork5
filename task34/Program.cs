/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] createArray()
{
    int n = new Random().Next(2, 10);
    int[] array = new int[n];
    for(int i = 0; i < n; i++){
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

    return array;
}

int printCountEvenNumbers(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++){
        if((array[i] % 2) == 0) n++;
    }
    return n;
}

int[] array = createArray();
Console.WriteLine(printCountEvenNumbers(array));