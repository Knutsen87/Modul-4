// See https://aka.ms/new-console-template for more information


string firstName    = GetTextInput("Gebe deinen Vornamen ein: ");
string lastName = GetTextInput("Gebe deinen Nachnamen ein: ");

Console.WriteLine("Hallo {0} {1}!", firstName, lastName);

static string GetTextInput(string message)
{
    Console.Write(message);
    return Console.ReadLine();
    
    Console.ReadKey();
}





