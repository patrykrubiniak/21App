using System.ComponentModel.Design;

namespace _21App;
public class Employee
{
    public List<float> grades = new List<float>();

    public Employee()
    { 
    }
    public Employee(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }

    public void AddGrades(float grade)
    {
        if (grade >= 0 && grade <= 100)

            this.grades.Add(grade);

        else
        {
            Console.WriteLine("Niepoprawne dane");
        }
    }
    public void AddGrades(double grade)
    {
        float gradeAsFloat = (float) grade;
        this.AddGrades(gradeAsFloat);
    }
    public void AddGrades(int grade)
    {
        float gradeAsFloat = grade;
        this.AddGrades(gradeAsFloat);
    }
    public void AddGrades(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrades(result);
        }

        else
        {
            Console.WriteLine("String to nie jest float");
        }
    }
    public void AddGrades(char grade)
    {
        switch (grade)
        {
            case 'A':
            case 'a':
                AddGrades(100);
                break;
            case 'B':
            case 'b':
                AddGrades(80);
                break;
            case 'C':
            case 'c':
                AddGrades(60);
                break;
            case 'D':
            case 'd':
                AddGrades(40);
                break;
            case 'F':
            case 'f':
                AddGrades(20);
                break;
            default:
                Console.WriteLine("Niepoprawna wartość");
                break;
        }
    }
    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }

        statistics.Average /= this.grades.Count;

        switch(statistics.Average)
        {
            case var average when average >= 80:
                statistics.AverageLetter = 'A';
                break;
            case var average when average >= 60:
                statistics.AverageLetter = 'B';
                break;
            case var average when average >= 40:
                statistics.AverageLetter = 'C';
                break;
            case var average when average >= 20:
                statistics.AverageLetter = 'D';
                break;
            default:
                statistics.AverageLetter = 'F';
                break;
        }
       
        return statistics;

    }
}