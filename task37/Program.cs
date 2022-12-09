/*Найдите произведение пар чисел в одномерном массиве.
Парой считается первый и последний элемент, второй и предпоследний и т. д.
Результат записать в новый массив.

[1,2,3,4,5] -> 5,8,3
[6,7,3,6] -> 36,21*/

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

int[] printPairMull(int[] arr)
{
    int[] newArr;
    if((arr.Length % 2) == 0){
        newArr = new int[arr.Length/2];
        for(int i = 0; i < newArr.Length; i++){
            newArr[i] = arr[i] * arr[(arr.Length - 1) - i];
            Console.Write($"{newArr[i]} ");
        }
    }
    else{
        newArr = new int[arr.Length/2 + 1];
        for(int i = 0; i < newArr.Length; i++){
            if(i == (newArr.Length - 1)){
                newArr[i] = arr[i];
                Console.Write($"{newArr[i]} ");
            }
            else{ 
                newArr[i] = arr[i] * arr[(arr.Length - 1) - i];
                Console.Write($"{newArr[i]} ");
            }
        }
    }

    return newArr;
}

int[] a = createArray();
printPairMull(a);