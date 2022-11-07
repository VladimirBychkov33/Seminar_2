// Дано число обозначающее день недели. Выяснить является ли номер дня недели выходным
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine($"Номер {number} является выходным днём");
}
else
{
    Console.WriteLine($"Номер {number} не является выходным днём");
}

