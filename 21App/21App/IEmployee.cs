namespace _21App
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        char Gender { get; }

        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(int grade);
        void AddGrade(double grade);
        void AddGrade(char grade);
        Statistics GetStatistics();
    }
}
