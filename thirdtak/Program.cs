Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 2) == 0)
{
    Console.WriteLine("четное" + number);
}
else
{
    Console.WriteLine("нечетное " + number);
}