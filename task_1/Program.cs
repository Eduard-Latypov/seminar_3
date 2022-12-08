// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


Console.Clear();
System.Console.WriteLine("Введите номер четверти");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        System.Console.WriteLine("x и y-положительные");
        break;
    case 2:
        System.Console.WriteLine("x-отрицательный, y-положительный");
        break;
    case 3:
        System.Console.WriteLine("x и y-отрицательные");
        break;
    case 4:
        System.Console.WriteLine("x-положительный, y-отрицательный");
        break;
    default:
        System.Console.WriteLine("нет такой четверти");
        break;
}

