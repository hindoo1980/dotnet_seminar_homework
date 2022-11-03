// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
Console.WriteLine($"{num1} larger than {num2} ");
}
else if (num2 > num1)
{
Console.WriteLine($"{num2} larger than {num1} ");
}
else if (num2 == num1)
{
Console.WriteLine($"{num2} equal {num1} ");
}