Console.WriteLine("Введите цифру, обозначающую день недели: ");
int N = int.Parse(Console.ReadLine());
if((N == 6) || (N == 7))
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}
