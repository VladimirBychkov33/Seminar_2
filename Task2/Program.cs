// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int sqr1 = number1 * number1;
int sqr2 = number2 * number2;
if(sqr1 == number2 || sqr2 == number1)
{
    Console.WriteLine("Одно из двух чисел является квадратом другого");
}
else
{
    Console.WriteLine("Ни одно из двух чисел не является квадратом другого");
}

