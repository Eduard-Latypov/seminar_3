// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
System.Console.Write("Введите число: ");
string num = Console.ReadLine();
bool isNumber = int.TryParse(num, out int numValue);
while (numValue <= 0 || isNumber == false)
{
    System.Console.WriteLine("Введите положительное число!");
    num = Console.ReadLine();
    isNumber = int.TryParse(num, out numValue);
}

for (int i = 1; i < numValue; i++)
{
    System.Console.Write($"{i * i * i}, ");
}
System.Console.WriteLine(numValue * numValue * numValue);