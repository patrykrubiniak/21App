using _21App;

var employee = new Employee("Karol", "Kowalski");

employee.AddGrades(2);
employee.AddGrades(2);
employee.AddGrades(5);
employee.AddGrades(7);

var statistics = employee.GetStatistics;
var statistics1 = employee.GetStatisticsWhile();
var statistics2 = employee.GetStatisticsDoWhile();
var statistics3 = employee.GetStatisticsFor();
var statistics4 = employee.GetStatisticsForEach();

Console.WriteLine("While");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine("");

Console.WriteLine("DoWhile");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine("");

Console.WriteLine("For");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine("");

Console.WriteLine("ForEach");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
