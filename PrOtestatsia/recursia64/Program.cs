/*Задача 64: Задайте значение N. Напишите программу, которая выведет все
 натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


Console.Clear();
Console.WriteLine("\n Задача 64");

Console.WriteLine("Введите число: ");
int omega = int.Parse(Console.ReadLine()!);

Console.WriteLine(Answer( 1, omega));

string Answer( int alpha, int numbers){
    if(alpha == numbers) return numbers.ToString();
    return (numbers +", "+ Answer(alpha , numbers- 1));
   
}


    