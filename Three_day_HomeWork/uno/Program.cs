/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое == последнему, второе == предпоследнему).
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("\n Задача 19");
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
string NumberStr = number.ToString();

if(NumberStr.Length<5 || NumberStr.Length>5) Console.WriteLine($"Число {NumberStr} не пятизначное");
else if(NumberStr[0] == NumberStr[4] && NumberStr [1] == NumberStr[3]) Console.WriteLine($"Да,число {NumberStr} является палиндромом");
else if(NumberStr[0] != NumberStr[4] || NumberStr [1] != NumberStr[3]) Console.WriteLine($"Нет,число {NumberStr} не является палиндромом");

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("\n Задача 21");
Console.WriteLine("введите первую точку:");
int ax = int.Parse(Console.ReadLine()!);
int ay = int.Parse(Console.ReadLine()!);
int az = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите вторую точку:");
int bx = int.Parse(Console.ReadLine()!);
int by = int.Parse(Console.ReadLine()!);
int bz = int.Parse(Console.ReadLine()!);

double s = Math.Sqrt(Math.Pow((bx-ax), 2)+Math.Pow((by-ay), 2)+Math.Pow((bz-az), 2));
Console.WriteLine($"Расстояние между A и B равно {s:f2}");

Console.WriteLine("\n Задача 23");
/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("введите число:");
int num = int.Parse(Console.ReadLine()!);

int index = 1;

while (index <= num)
{
 Console.WriteLine(Math.Pow(index, 3));  
 index++; 
}
