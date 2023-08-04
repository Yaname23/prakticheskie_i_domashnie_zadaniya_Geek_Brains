/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.WriteLine("\n Задача 34");

int[]array_random = GetArray(7, 100, 999);
Console.WriteLine($"[{String.Join(",", array_random)}]");

int sum = 0;

for(int i = 0; i < array_random.Length; i++ )
{
    sum += (array_random[i]%2 == 0 )? 1:0;
}
Console.WriteLine($"количество чётных:{sum}");

int[]GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;

}
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("\n Задача 36");
int[]array_ran = GetArr(6, 1, 50);
Console.WriteLine($"[{String.Join(",", array_ran)}]");
int num = 0;
for (int i = 1; i < array_ran.Length; i+=2)
    num = num + array_ran[i];

Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях = {num}");

int[]GetArr(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
/*Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3, 4, 1, 77, 65] => 77 - 1 = 76*/

Console.WriteLine("\n Задача 38");
int[]mass = GetA(5, 1, 50);
Console.WriteLine($"[{String.Join(",", mass)}]");
int min = 50;
int max = 0;
foreach (int i in mass){
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"Максимальный элемент: {max}. Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом составляет: {max-min}");

int[]GetA(int size, int minValue, int maxValue){
    int[] result = new int[size]; 
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

