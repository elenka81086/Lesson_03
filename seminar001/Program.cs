int Number1 = new int();
Console.WriteLine("Введите число");
Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = new int();
Console.WriteLine("Введите число");
Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Большее число ");
if(Number1 < Number2)
{
    Console.WriteLine(Number2);
}
else
{
    Console.WriteLine(Number1);
}