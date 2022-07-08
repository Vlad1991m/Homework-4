int Product(int num)
{
    int sum = 0;

    if (num < 0) Console.WriteLine(num = -1);
    else
    {
        while (num > 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
        
    }
    return sum;
}
Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Product(a));

