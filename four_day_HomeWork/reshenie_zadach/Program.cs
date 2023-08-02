/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("\n Задача № 25");
Console.Write("Введите число:");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите ещё одно число:");
int B = int.Parse(Console.ReadLine()!);

int result = A;

for (int i = 1; i <= B; i++)
{
    result = Convert.ToInt32(Math.Pow(A, B));;
}

Console.WriteLine($" число {A} в степени {B} равно {result}");

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.WriteLine("\n Задача № 27");

Console.Write("Введите число:");
int S  = int.Parse(Console.ReadLine()!);
int summa = 0;

while (S > 0)
{
int num = S % 10;
S = S/ 10;
summa = summa + num;
}
Console.WriteLine($"сумма всех цифр в числе равна:{summa} " );

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
Console.WriteLine("\n Задача № 29");

int[] array = GetRange(8);
Console.WriteLine($"[{String.Join(",", array)}]");
int[] GetRange(int size){
    int[] massive = new int[size];
    for(int i = 0; i < massive.Length; i++){
        massive[i] = new Random().Next(0, 50);
    }
    return massive;

}
