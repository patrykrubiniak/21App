using System.Reflection;

namespace _21App.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsMax()
        {
            //arrange
            var employee = new EmployeeInFile ("Karol", "Kowalski", 'M', 32);
            employee.AddGrade(50);
            employee.AddGrade(80);
            employee.AddGrade(20);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.That(statistics.Max, Is.EqualTo(80));
        }

        [Test]
        public void StatisticsMin()
        {
            var employee = new EmployeeInFile ("Karol", "Kowalski", 'M', 32);
            employee.AddGrade(50);
            employee.AddGrade(80);
            employee.AddGrade(20);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Min, Is.EqualTo(20));
        }

        [Test]
        public void StatistsicsAverage()
        {
            var employee = new EmployeeInFile ("Karol", "Kowalski", 'M', 32);
            employee.AddGrade(50);
            employee.AddGrade(80);
            employee.AddGrade(20);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Average, Is.EqualTo(50));
        }

        [Test]
        public void StatistsicsFinalGrade()
        {
            var employee = new EmployeeInFile ("Karol", "Kowalski", 'M', 32);
            employee.AddGrade(50);
            employee.AddGrade(80);
            employee.AddGrade(20);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
        }
        public EmployeeInFile GetEmployee (string name, string surname, char gender, int age)
        {
            return new EmployeeInFile( name,  surname,  gender,  age);
        }
    }
}