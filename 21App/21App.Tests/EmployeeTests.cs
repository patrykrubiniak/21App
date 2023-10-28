namespace _21App.Tests
{
    public class TypeTests
    {
        [Test]
        public void ComparedNumbers_AreNotEqual()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act
            //assert
            Assert.AreNotEqual(number1, number2);  

        }
        
        [Test]
        public void TwoNames_AreTheSame()
        {
            
            string name1 = "Karol";
            string name2 = "Karol";
                  
            Assert.AreEqual(name1, name2);

        }
       
        [Test]
        public void ComparedEmployees_AreNotTheSame()
        {
            
            var emp1oyee1 = GetEmployee("Karol", "Kowalski", 21);
            var employee2 = GetEmployee("Adam", "Nowak", 34);

            Assert.AreNotEqual(emp1oyee1, employee2);

        }
        
        [Test]
        public void ComparedNumbers_AreEqual()
        {
            
            float number1 = 999;
            float number2 = 999;

            Assert.AreEqual(number1, number2);

        }
        private Employee GetEmployee(string name, string surname, int age)
        {                                           
            return new Employee(name, surname, age);
        }

    }
}