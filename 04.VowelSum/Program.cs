int num = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 0; i < num; i++)
{
    int stringToNum = 0;
    string charc = Console.ReadLine();
    switch (charc)
    {
        case "a": stringToNum = 1; break;
        case "e": stringToNum = 2; break;
        case "i": stringToNum = 3; break;
        case "o": stringToNum = 4; break;
        case "u": stringToNum = 5; break;

    }  result += stringToNum;
}
Console.WriteLine(result);