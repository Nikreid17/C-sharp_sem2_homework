// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int rem = num % 100;
int dec = rem / 10;
if (num < 99 || num > 1000)
{
    Console.WriteLine($"Число {num} не трёхзначное");
}
else
{
  Console.WriteLine($"Вторая цифра числа {num} - {dec}");  
} 