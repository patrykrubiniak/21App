﻿using System.ComponentModel.Design;

namespace _21App;
public class Employee : IEmployee
{
    private List<float> grades = new List<float>();

    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public char Gender { get; private set; }
    public int Age { get; private set; }

    public void AddGrade(float grade)
    {
        throw new NotImplementedException();
    }

    public void AddGrade(string grade)
    {
        throw new NotImplementedException();
    }

    public void AddGrade(long grade)
    {
        throw new NotImplementedException();
    }

    public void AddGrade(double grade)
    {
        throw new NotImplementedException();
    }

    public void AddGrade(char grade)
    {
        throw new NotImplementedException();
    }

    public void AddGrades(float grade)
    {
        if (grade >= 0 && grade <= 100)

            this.grades.Add(grade);

        else
        {
            throw new Exception ("Niepoprawne dane");
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
            throw new Exception ("String to nie jest float");
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
                throw new Exception ("Niepoprawna wartość");               
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