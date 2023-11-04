using _21App;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

Employee employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    { 
        break; 
    }
    employee.AddGrades(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
Console.WriteLine($"Najniższa ocena: {statistics.Min}");
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Ocena końcowa: {statistics.AverageLetter}");                