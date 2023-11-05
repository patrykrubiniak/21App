namespace _21App.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsMax()
        {
            //arrange
            var employee = new Employee("Karol", "Kowalski");
            employee.AddGrades(50);
            employee.AddGrades(80);
            employee.AddGrades(20);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.That(statistics.Max, Is.EqualTo(80));
        }

        [Test]
        public void StatisticsMin()
        {
            var employee = new Employee("Karol", "Kowalski");
            employee.AddGrades(50);
            employee.AddGrades(80);
            employee.AddGrades(20);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Min, Is.EqualTo(20));
        }

        [Test]
        public void StatistsicsAverage()
        {
            var employee = new Employee("Karol", "Kowalski");
            employee.AddGrades(50);
            employee.AddGrades(80);
            employee.AddGrades(20);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Average, Is.EqualTo(50));
        }

        [Test]
        public void StatistsicsFinalGrade()
        {
            var employee = new Employee("Karol", "Kowalski");
            employee.AddGrades(50);
            employee.AddGrades(80);
            employee.AddGrades(20);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
        }
        public Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}