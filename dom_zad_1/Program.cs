// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Я думаю, нет смысла проверять число на пятизначность, потому что любое число может быть палиндромом

Console.Clear();
System.Console.WriteLine("Введите число для проверки на палиндром");
string num = Console.ReadLine();
bool isNumber = int.TryParse(num, out int numValue);
while (num.Length == 0 || isNumber == false)
{
    System.Console.WriteLine("Укурыш, тебя просят ввести ЧИСЛО: ");
    num = Console.ReadLine();
    isNumber = int.TryParse(num, out numValue);
}

string CheckNum(string num)
{
    for (int i = 0; i < (num.Length / 2); i++)
    {
        if (num[i] != num[(num.Length - 1) - i])
        {
            return ($"Нет, число {num} - не палиндром!");
        }
    }
    return ($"Да, число {num} - палиндром!");
}

System.Console.WriteLine(CheckNum(num));

