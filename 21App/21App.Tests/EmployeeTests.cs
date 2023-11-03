namespace _21App.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsMax()
        {
            //arrange
            var employee = new Employee("Karol", "Kowalski");
            employee.AddGrades(5);
            employee.AddGrades(8);
            employee.AddGrades(2);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.That(statistics.Max, Is.EqualTo(8));

        }

        [Test]
        public void StatisticsMin()
        {
            var employee = new Employee("Karol", "Kowalski");
            employee.AddGrades(5);
            employee.AddGrades(8);
            employee.AddGrades(2);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Min, Is.EqualTo(2));

        }

        [Test]
        public void StatistsicsAverage()
        {

            var employee = new Employee("Karol", "Kowalski");
            employee.AddGrades(5);
            employee.AddGrades(8);
            employee.AddGrades(2);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Average, Is.EqualTo(5));

        }
        public Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}