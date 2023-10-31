using _21App;

var employee = new Employee("Karol", "Kowalski");

employee.AddGrades(2);
employee.AddGrades(5);
employee.AddGrades(7);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
