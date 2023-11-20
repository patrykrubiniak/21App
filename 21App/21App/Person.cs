namespace _21App
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }

        public Person(string name, string surname, char gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }
    }
}