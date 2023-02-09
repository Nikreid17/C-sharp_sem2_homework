// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
if (day < 1 || day > 7)
{
    Console.Write("Это не номер дня недели");
    return;
}
if (day == 6 || day ==7)
{
    Console.Write("Этот день выходной");
}
else
{
    Console.Write("Этот день рабочий");
}