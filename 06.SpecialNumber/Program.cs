using System.ComponentModel.Design;

int num = int.Parse(Console.ReadLine());

bool isSpecial = true;
int copyNum = num;
while (copyNum > 0)
{
    int lastDigit = copyNum % 10;
    if (num % lastDigit != 0)
    {
        isSpecial = false;
        break;
    }
    copyNum /= 10;

}
if (isSpecial)
{
    Console.WriteLine($"{num} is special");
}
else { Console.WriteLine($"{num} is not special"); }
