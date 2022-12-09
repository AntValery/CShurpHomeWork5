/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] createArray()
{
    int n = new Random().Next(2, 10);
    double[] array = new double[n];
    for(int i = 0; i < n; i++){
        array[i] = new Random().Next(-100, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

    return array;
}

double subtraction(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++){
        if(array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }

    return max - min;

}


double[] array = createArray();
Console.WriteLine(subtraction(array));
