string Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, A1 = "", A2 = "", A3 = "", A4 = "", A5 = "", A6 = "", A7 = "", A8 = "", A9 = "", A10 = "", A11 = "", A12 = "", A13 = "", A14 = "", A15 = "", A16 = "", A17 = "", A18 = "", A19 = "", A20 = "", A21 = "", A22 = "", A23 = "";
bool status = true;
Q1 = "Are you married ?";
Q2 = "Do you have more than 2 children ?";
Q3 = "Do you own a house ? ";
Q4 = "Do you own a car ?";
Q5 = "Is your salary more than $100K per year ?";
Q6 = "You can get a loan amount of $80K";
Q7 = "You can get a loan amount of $50K";
//-----------------------------------------------------//
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("This program will show you how much loan you can get.");
Console.WriteLine();
Console.WriteLine("Answer the questions with Y/N (yes / no) to calculate the loan amount.");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("----------------------------------------------------");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Gray;
Possibilities();
Answers();
void Possibilities()
{
    Console.WriteLine(Q1);
    A1 = Console.ReadLine();
    switch (A1.ToLower())
    {

        case "y":
            break;

        case "n":
            break;


        default:
            Console.WriteLine("Invalid Input");
            status = false; break;
    }
    if (A1 == "y")
    {
        Console.WriteLine(Q2);
        A2 = Console.ReadLine();
        switch (A2.ToLower())
        {

            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A1 == "n")
    {
        Console.WriteLine(Q3);
        A3 = Console.ReadLine();
        switch (A3.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A2 == "y")
    {
        Console.WriteLine(Q3);

        A4 = Console.ReadLine();
        switch (A4.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A2 == "n")
    {
        Console.WriteLine(Q3);

        A5 = Console.ReadLine();
        switch (A5.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A3 == "y")
    {
        Console.WriteLine(Q4);

        A6 = Console.ReadLine();
        switch (A6.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A3 == "n")
    {
        Console.WriteLine(Q4);

        A7 = Console.ReadLine();
        switch (A7.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A4 == "y")
    {
        Console.WriteLine(Q4);

        A8 = Console.ReadLine();
        switch (A8.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A4 == "n")
    {
        Console.WriteLine(Q4);

        A9 = Console.ReadLine();
        switch (A9.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A5 == "y")
    {
        Console.WriteLine(Q4);

        A10 = Console.ReadLine();
        switch (A10.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A5 == "n")
    {
        Console.WriteLine(Q4);

        A11 = Console.ReadLine();
        switch (A11.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A6 == "y")
    {
        Console.WriteLine(Q5);

        A12 = Console.ReadLine();
        switch (A12.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A6 == "n")
    {
        Console.WriteLine(Q5);

        A13 = Console.ReadLine();
        switch (A13.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A7 == "y")
    {
        Console.WriteLine(Q5);

        A14 = Console.ReadLine();
        switch (A14.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A7 == "n")
    {
        Console.WriteLine(Q5);

        A15 = Console.ReadLine();
        switch (A15.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A8 == "y")
    {
        Console.WriteLine(Q5);

        A16 = Console.ReadLine();
        switch (A16.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A8 == "n")
    {
        Console.WriteLine(Q5);

        A17 = Console.ReadLine();
        switch (A17.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A9 == "y")
    {
        Console.WriteLine(Q5);

        A18 = Console.ReadLine();
        switch (A18.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A9 == "n")
    {
        Console.WriteLine(Q5);

        A19 = Console.ReadLine();
        switch (A19.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A10 == "y")
    {
        Console.WriteLine(Q5);

        A20 = Console.ReadLine();
        switch (A20.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A10 == "n")
    {
        Console.WriteLine(Q5);

        A21 = Console.ReadLine();
        switch (A21.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A11 == "y")
    {
        Console.WriteLine(Q5);

        A22 = Console.ReadLine();
        switch (A22.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
    if (A11 == "n")
    {
        Console.WriteLine(Q5);

        A23 = Console.ReadLine();
        switch (A23.ToLower())
        {
            case "y":
                break;

            case "n":
                break;


            default:
                Console.WriteLine("Invalid Input");
                status = false; break;
        }
    }
}
void Answers()
{
    if (A12 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A12 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A13 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A13 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A14 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A14 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A15 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A15 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A16 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A16 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A17 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A17 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A18 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A18 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A19 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A19 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A20 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A20 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A21 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A21 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A22 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A22 == "n")
    {
        Console.WriteLine(Q7);
    }
    if (A23 == "y")
    {
        Console.WriteLine(Q6);
    }
    if (A23 == "n")
    {
        Console.WriteLine(Q7);
    }
}