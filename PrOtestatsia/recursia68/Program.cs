/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();
Console.WriteLine("\n Задача 68");

Console.WriteLine("Введите первое неотрицательное число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите ещё одно неотрицательное число: ");
int n = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Результат вычисления функции Аккермана при введении чисел({m}, {n}) = {Akkerman(m, n)}");

/*int InputInt(string output){
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}*/

int Akkerman(int m, int n){
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

 /*int SummNumbers (int m, int n){
    if (m == n) return n;
    return n + SummNumbers(m, n - 1);
}
*/

