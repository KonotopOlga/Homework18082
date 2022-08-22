/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
//Cоздаем массив из восьми элементов
//Создаем объект для генерации чисел
//Получаем случайное число
//Цикл должен проходить только по нечетным элементам, 
//и для этого к i прибавляем 2


int[] arr = new int[5];

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(-100, 100);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

RandomArray(arr);

void GetOddSum(int[] array)
{
    int oddSum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        oddSum += arr[i];
    }
    Console.WriteLine($"Сумма элементов с нечетным индексом равна: {oddSum}");
}

GetOddSum(arr);