Console.WriteLine("введите три числа  ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

if (number3 < number1 && number1> number2)
{
    Console.WriteLine("макс" + number1);
}
else 
if (number2 < number3 && number3 > number1)
{
    Console.WriteLine("макс" + number3);
}
else
if (number1 < number2 && number2 > number3)
{
    Console.WriteLine("макс" + number2);
}