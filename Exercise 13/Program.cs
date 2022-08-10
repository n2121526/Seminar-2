Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if((num / 100) % 10 == 0)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"{(num / 100) % 10}");
}

