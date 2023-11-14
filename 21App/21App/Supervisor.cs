namespace _21App
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, char gender, int age)          
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
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
                throw new Exception("Niepoprawne dane");
            }
        }
        public void AddGrades(double grade)
        {
            float gradeAsFloat = (float)grade;
            AddGrades(gradeAsFloat);
        }
        public void AddGrades(int grade)
        {
            float gradeAsFloat = grade;
            AddGrades(gradeAsFloat);
        }
        public void AddGrades(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    this.AddGrade(95);
                    break;
                case "+5":
                case "5+":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "-5":
                case "5-":
                    this.AddGrade(75);
                    break;
                case "+4":
                case "4+":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "-4":
                case "4-":
                    this.AddGrade(55);
                    break;
                case "+3":
                case "3+":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "-3":
                case "3-":
                    this.AddGrade(35);
                    break;
                case "+2":
                case "2+":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "-2":
                case "2-":
                    this.AddGrade(15);
                    break;
                case "+1":
                case "1+":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    if (float.TryParse(grade, out float result))
                    {
                        this.AddGrade(result);
                        break;
                    }
                    else if (char.TryParse(grade, out char result1))
                    {
                        this.AddGrade(result1);
                        break;
                    }
                    else
                    {
                        throw new Exception("String to nie jest float");
                    }
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
                    throw new Exception("Niepoprawna wartość");
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

            switch (statistics.Average)
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
}

