// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
string s = Console.ReadLine();
int num = int.Parse(s);
if (num < 100)
{
    Console.WriteLine($"У числа {num} третьей цифры нет.");
    return;
}
string third = Convert.ToString(s[2]);
Console.WriteLine($"Третья цифра числа - {third}");