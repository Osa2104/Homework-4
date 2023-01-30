// принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

System.Console.WriteLine(GetSum(new Random(). Next(1000, 1000000)));
static int GetSum(int num)
{
    System.Console.WriteLine(num);
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num %10;
        num /= 10;
    }
    return sum; 
}

 

 