void positiv(params int[] m)
{
    int count = 0;
    for (int i = 0; i < m.Length; i++)
    {
        if (m[i] > 0) count++;
    }
    Console.WriteLine("positive count is {0}", count);
}
Console.WriteLine("enter numbers");
int[] array = Console.ReadLine().
Split(",").
Select(item => Convert.
ToInt32(item)).
ToArray();

//dinamicheskiy vvod chisel s preobrazovaniem v massiv eto ochen kruto)))

positiv(array);
