int num = int.Parse(Console.ReadLine());

int biggestN = int.MinValue;

for (int i = 0; i < num; i++)
{
    int currentN = int.Parse(Console.ReadLine());
    if (currentN > biggestN)
    {
        biggestN = currentN;
    }
}
Console.WriteLine(biggestN);
