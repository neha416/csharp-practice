int[] numbers = { 3, 7, 2, 9, 5 };
int max = numbers[0];

foreach (int num in numbers)
{
    if (num > max)
        max = num;
}

Console.WriteLine("Largest: " + max);
