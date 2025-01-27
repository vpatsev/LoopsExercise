double balance = 0;
string end;

while ((end = Console.ReadLine()) != "End")

{
    double money = double.Parse(end);
    balance += money;

    if (money >= 0)
    {
        Console.WriteLine($"Increase: {money:F2}");

    }
    else
    {
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");


    }



}

Console.WriteLine($"Balance: {balance:F2}");




