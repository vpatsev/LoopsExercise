int stopNum = int.Parse(Console.ReadLine());
int prevNum = 0;

while (true)

{
    int num = int.Parse(Console.ReadLine());

    if (num == stopNum)
    {
        break;

    }

    prevNum = num;



}
Console.WriteLine(prevNum * 1.2);



