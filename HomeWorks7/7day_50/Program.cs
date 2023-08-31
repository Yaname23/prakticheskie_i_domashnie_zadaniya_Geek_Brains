/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

позиция i = 4, j = 2 -> такой позиции нет
позиция i = 1, j = 0 -> 5*/

Console.WriteLine("\n Задача 50");

Console.WriteLine("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите строку, в которой должен находиться элемент: ");
 int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец, в котором должен находиться элемент: ");
 int y = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);

// Создание массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}
// Печать массива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if( x >= 0 && x < array.GetLength(0) && y>=0 && y < array.GetLength(1)){
                //int element = {array[x-1,y-1]:F2};
                Console.WriteLine($"Элемент находящийся в {x} строке, {y} столбце имеет значение {array[x-1,y-1]} ");
                return;

            }
            else Console.WriteLine("Такой позиции нет");
            return;
        }
        
}

