Console.WriteLine("This program shows the prime numbers between 2 variables");
Console.WriteLine("Please enter your first number");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your second number");
int y = Convert.ToInt32(Console.ReadLine());
if (y < x) throw new Exception("ERROR : Second number should be larger than the first one");
Console.WriteLine("Your prime numbers are : ");
for (int i = x; i < y; i++)
{
    bool Prime = true;
    {
        for (int j = 2; j < i; j++)
            if (i % j == 0)
            {
                Prime = false;
            }
    }
    if (Prime & i != 0 & i != 1)
        Console.Write(i + " - ");
}