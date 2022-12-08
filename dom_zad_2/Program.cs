// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Сonsole.Clear();
string[] arr = { "A", "B" };
string[] arrPoint = { "x", "y", "z" };
System.Console.WriteLine("Вычисляем расстояние между точками в 3D пространстве!");
int[] numbers = new int[6];
int index = 0;
foreach (var item in arr)
{
    System.Console.WriteLine($"Введите координаты для точки:");
    System.Console.Write($"{item}: ");
    for (int i = 0; i < arrPoint.Length; i++)
    {
        System.Console.Write($"\t {arrPoint[i]}: ");
        int num = int.Parse(Console.ReadLine());
        numbers[index] = num;
        index++;
    }
}
int[] sumPow = new int[3];
for (int i = 0; i < (numbers.Length / 2); i++)
{
    sumPow[i] = (int)Math.Pow((numbers[i + 3] - numbers[i]), 2);
}
System.Console.Write($"Расстояние между точками: ");
System.Console.WriteLine(Math.Sqrt(sumPow.Sum()));



