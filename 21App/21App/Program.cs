using _21App;

Employee employee1 = new Employee("Karol", "Kowalski", 21);
Employee employee2 = new Employee("Adam", "Nowak", 34);
Employee employee3 = new Employee("Eliza", "Miś", 28);

employee1.AddScore(7);
employee1.AddScore(1);
employee1.AddScore(4);
employee1.AddScore(3);
employee1.AddScore(5);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(3);
employee2.AddScore(4);

employee3.AddScore(9);
employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(9);
employee3.AddScore(10);

List<Employee> employees = new List<Employee>()

{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + "w wieku" + " " + employeeWithMaxResult.Age + " " + "lat");
Console.WriteLine("Z wynikiem" + " " + employeeWithMaxResult.Result + " " + "pkt.");