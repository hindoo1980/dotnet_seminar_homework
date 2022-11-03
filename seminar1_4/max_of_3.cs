// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2) {
max = num2;
}
if (max < num3) {
max = num3;
}
Console.WriteLine(max);