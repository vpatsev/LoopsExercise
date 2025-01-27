int numInt = int.Parse(Console.ReadLine());
double devisibleBy2 = 0;
double devisibleBy3 = 0;
double devisibleBy4 = 0;
for (int i = 0; i < numInt; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        devisibleBy2++;
    }
    if (num % 3 == 0)
    {
        devisibleBy3++;
    }
    if (num % 4 == 0)
    {
        devisibleBy4++;
    }

}
double percBy2 = (devisibleBy2 / numInt) * 100;
double percBy3 = (devisibleBy3 / numInt) * 100;
double percBy4 = (devisibleBy4 / numInt) * 100;
Console.WriteLine($"{percBy2:F2}%");
Console.WriteLine($"{percBy3:F2}%");
Console.WriteLine($"{percBy4:F2}%");
