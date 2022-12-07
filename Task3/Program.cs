Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов от 1 до {num}");

for (int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}