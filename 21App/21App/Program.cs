using _21App;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

var employee = new EmployeeInFile ("Karol", "Kowalski", 'M', 32);
var supervisor = new Supervisor ("Karol", "Kowalski", 'M', 32);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    { 
        break; 
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception exception)
    { 
        Console.WriteLine($"Znaleziono wyjątek: {exception.Message}"); 
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
Console.WriteLine($"Najniższa ocena: {statistics.Min}");
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Ocena końcowa: {statistics.AverageLetter}");                