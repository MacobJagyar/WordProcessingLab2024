while (true)
{
    Console.Write("Hello! Please enter a sentence: ");
    string input = Console.ReadLine();
    string[] inputArr = input.Split(" ");

    foreach (string s in inputArr)
    {
        Console.WriteLine(s);
    }

    Console.Write("\nWould you like to try again? (y/n) ");
    string loopchoice = Console.ReadLine().ToLower();

    if (loopchoice == "y")
    {
        Console.WriteLine("\nRestarting...");
        Thread.Sleep(1500);
        Console.Clear();
    }
    else if (loopchoice == "n")
    {
        Console.WriteLine("\nGoodbye!");
        break;
    }
    else
    {
        Console.WriteLine("\nThat wasn't y or n! Restarting anyways...");
        Thread.Sleep(1500);
        Console.Clear();
    }


}