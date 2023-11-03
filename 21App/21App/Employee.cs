using System.ComponentModel.Design;

namespace _21App;
public class Employee
{
    public List<float> grades = new List<float>();
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
    public void AddGrades(double grade)
    {
        float value = (float)grade;
        this.AddGrades(value);
    }
    public void AddGrades(int grade)
    {
        float value = grade;
        this.AddGrades(value);
    }
    public void AddGrades(long grade)
    {
        float value = grade;
        this.AddGrades(value);
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

        return statistics;
    }
    public Statistics GetStatisticsWhile()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        var index = 0;

        while (index < this.grades.Count)
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            statistics.Average += this.grades[index];
            index++;
        }

        statistics.Average /= this.grades.Count;

        return statistics;
    }
    public Statistics GetStatisticsDoWhile()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        var index = 0;

        do
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            statistics.Average += this.grades[index];
            index++;
        } while (index < this.grades.Count);

        statistics.Average /= this.grades.Count;

        return statistics;
    }
    public Statistics GetStatisticsFor()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        var index = 0;

        for (int i = 0; i < grades.Count; i++)
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[i]);
            statistics.Min = Math.Min(statistics.Min, this.grades[i]);
            statistics.Average += this.grades[i];
        }

        statistics.Average /= this.grades.Count;

        return statistics;
    }
    public Statistics GetStatisticsForEach()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        var index = 0;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }

        statistics.Average /= this.grades.Count;

        return statistics;
    }
}