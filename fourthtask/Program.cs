Console.Write("введите число  ");
int number = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[number];
for (int i = 0; i < myArray.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.Write("четное " + i + " ");
    }
}

 