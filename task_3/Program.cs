// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i < num; i++)
{
    System.Console.Write((i * i) + ", ");
}
System.Console.Write(num * num + ".");