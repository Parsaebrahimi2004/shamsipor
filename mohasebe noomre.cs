using System.Numerics;

int x;
Console.WriteLine("Enter the score");
x=Convert.ToInt32(Console.ReadLine());
if (x > 20)
{
    Console.WriteLine("namosan chejori bishtar az 20 gerefti ?!");
}
else if (x >= 17)
{
    Console.WriteLine("Congrats! you earned rank A ");
}
else if (x >= 15)
{
    Console.WriteLine("Not bad but you can do better. you earned rank B");
}
else if (x >= 10)
{
    Console.WriteLine("Well at least you passed. you earned rank C");
}
else if (x < 10)
{
    Console.WriteLine("I have nothing to say ... you FAILED");
}
int percentComplete = (int)Math.Round((double)(100 * x) / 20);
Console.WriteLine("Your score in percentage : "); Console.WriteLine(percentComplete);