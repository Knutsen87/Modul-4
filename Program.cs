// See https://aka.ms/new-console-template for more information


string firstName    = GetTextInput("Gebe deinen Vornamen ein: ");
string lastName = GetTextInput("Gebe deinen Nachnamen ein: ");

Console.WriteLine("Hallo {0} {1}!\n\n", firstName, lastName);

static string GetTextInput(string message)
{
    Console.Write(message);
    return Console.ReadLine();
    
    Console.ReadKey();
}

// Teil 2 der Übungsaufgabe
Console.Write("Geben Sie einen Radius ein: ");
double radius = Convert.ToDouble(Console.ReadLine());
double area = GetCircleArea(radius);

Console.WriteLine("Der Kreis hat einen Radius von  {0}cm und eine Fläche von {1}cm²\n", radius, area );

static double GetCircleArea(double radius)
{
    return Math.PI * radius * radius;
}

Console.WriteLine("Vielen Dank und bis zum nächsten Mal!");
Console.ReadKey();




