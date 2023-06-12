// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
int index = 2;
if (index <= num)
{
    Console.Write(index);
}
else
{
    Console.WriteLine("Четных чисел нет");
}
while (index <= num - 2)
{
    index = index + 2;
    Console.Write(", " +index);
}