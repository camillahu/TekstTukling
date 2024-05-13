
using System.Xml;

string userInput = "";
bool running = true;
void Run()
{   
    Console.WriteLine("Welcome!");

    while(running) {
        Console.WriteLine("Choose one of the following options:");
        Console.WriteLine("1. Rotate Text");
        Console.WriteLine("2. Change Text");
        Console.WriteLine("3. Exit");
        userInput = Console.ReadLine();
        int userInputInt = CheckUserInput(userInput);
        ChooseMethod(userInputInt);

    }
}

void ChooseMethod(int input)
{

    if (input == 1)
    {
        Console.Write("Write a text you would like to rotate.");
        string userInputText = Console.ReadLine();
        string rotatedText = RotateText(userInputText);
        Console.WriteLine($"Rotated text: {rotatedText} ");
    }
    else if (input == 2)
    {
        Console.Write("Write a text you would like to change.");
        string userInputText = Console.ReadLine();
        string changedText = ChangeText(userInputText);
        Console.WriteLine($"Changed text: {changedText}");
    }
    else if (input == 3)
    {
        Environment.Exit(0);
    }
    
}
int CheckUserInput(string input)

{
    if (input == "1" || input == "2" || input == "3")
    {
        return int.Parse(input);
    }
    else
    {
        Console.WriteLine("Please type 1, 2 or 3 to choose an option.");
        return 0;
    }
}

string RotateText(string input)
{
    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

string ChangeText(string input)
{
    char[] charArray = input.ToCharArray();

    foreach (char c in charArray)
    {
        if (c == 'e')
        {
            input = input.Replace(c, 'a');
        }
        else if (c == 'E')
        {
            input = input.Replace(c, 'A');
        }
    }
    return input;
}

Run();
