/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
 натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Clear();
Console.WriteLine("\n Задача 66");

Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите ещё одно число: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("\n числа в промежутке от М до N: ");
Console.WriteLine(Answer(m, n));

Console.WriteLine("\n сумма этих чисел: ");
Console.WriteLine(SummNumbers(m, n));

string Answer( int alpha, int numbers){
    if(alpha == numbers) return alpha.ToString();
    return (alpha +", "+ Answer(alpha + 1, numbers));

}

int SummNumbers (int m, int n){
    if (m == n) return n;
    return n + SummNumbers(m, n - 1);
}
