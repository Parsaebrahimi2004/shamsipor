// Parsa Ebrahimi - shamsipoor
using System.Runtime.InteropServices;


    int Score;
    System.ConsoleKeyInfo Output;
    string YN;
    do
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Enter the score");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Score = 0;

    EntryPoint();
    Calculations();
   

     //////Step 3 : yes or no//////

    Console.ForegroundColor = ConsoleColor.DarkCyan;
         Console.WriteLine("for continuing program press Y and for stopping program press N");
        
            do
            {
                YN = Console.ReadKey(true).Key.ToString();
            }
            while (YN.ToLower() != "y" && YN.ToLower() != "n");

    } while (YN.ToLower() == "y") ;

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("**THANK YOU FOR USING THIS PROGRAM** ");
        Console.WriteLine("▒▒▒░░░░░░░░░░▄▐░░░░\r\n▒░░░░░░▄▄▄░░▄██▄░░░\r\n░░░░░░▐▀█▀▌░░░░▀█▄░\r\n░░░░░░▐█▄█▌░░░░░░▀█▄\r\n░░░░░░░▀▄▀░░░▄▄▄▄▄▀▀\r\n░░░░░▄▄▄██▀▀▀▀░░░░░\r\n░░░░█▀▄▄▄█░▀▀░░░░░░\r\n░░░░▌░▄▄▄▐▌▀▀▀░░░░░\r\n░▄░▐░░░▄▄░█░▀▀░░░░░\r\n░▀█▌░░░▄░▀█▀░▀░░░░░\r\n░░░░░░░░▄▄▐▌▄▄░░░░░\r\n░░░░░░░░▀███▀█░▄░░░\r\n░░░░░░░▐▌▀▄▀▄▀▐▄░░░\r\n░░░░░░░▐▀░░░░░░▐▌░░\r\n░░░░░░░█░░░░░░░░█░░\r\n░░░░░░▐▌░░░░░░░░░█░");





































void EntryPoint()
{
    do
    {
        do
        {
            Output = Console.ReadKey(true);
        }
        while
          (Output.KeyChar.ToString() != "0" && Output.KeyChar.ToString() != "1" && Output.KeyChar.ToString() != "2"
        && Output.KeyChar.ToString() != "3" && Output.KeyChar.ToString() != "4" && Output.KeyChar.ToString() != "5"
        && Output.KeyChar.ToString() != "6" && Output.KeyChar.ToString() != "7" && Output.KeyChar.ToString() != "8"
        && Output.KeyChar.ToString() != "9" && Output.Key.ToString() != "Enter");

        if (Output.Key.ToString() != "Enter")
        {
            Score = Score * 10 + Convert.ToInt32(Output.KeyChar.ToString());
            Console.Write(Output.KeyChar);
        }

    } while (Output.Key.ToString() != "Enter");
}

void Calculations()
{
    if (Score >= 0 & Score <= 20)
    {
        Console.WriteLine();

        if (Score >= 17)
        {
            Console.WriteLine("Congrats! you earned rank A ");
        }
        else if (Score >= 15)
        {
            Console.WriteLine("Not bad but you can do better. you earned rank B");
        }
        else if (Score >= 10)
        {
            Console.WriteLine("Well at least you passed. you earned rank C");
        }
        else
        {
            Console.WriteLine("I have nothing to say ... you FAILED");
        }

        int percentComplete = (int)Math.Round((double)(100 * Score) / 20);
        Console.Write("Your score in percentage : "); Console.WriteLine(percentComplete + "%");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(); Console.WriteLine("Enter a score between 0 to 20");
    }
}




