namespace _21App.Tests
{
    public class Tests
    {
        [Test]
        public void WhenPointsAreAdded_ShouldReturnCorrectSumofPoints()
        {
            //arrange
            var employee = new Employee("Karol", "Kowalski", 21);
            
            employee.AddScore(7);
            employee.AddScore(6);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(13, result);
        }

        [Test]
        public void WhenPointsAreSubstracted_ShouldReturnCorrectSumofPoints()
        {
            //arrange
            var employee = new Employee("Adam", "Nowak", 34);
           
            employee.AddScore(12);
            employee.AddScore(4);
            employee.AddScore(-9);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(7, result);
        }

    }
}
  