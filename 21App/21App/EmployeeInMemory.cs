namespace _21App
{
    public class EmployeeInMemory : EmployeeBase
    {       
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeInMemory (string name, string surname, char gender, int age)
            : base(name, surname, gender, age)
        {
       
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Niepoprawna wartość oceny");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String to nie float");
            }
        }

        public override void AddGrade(int grade)
        {
            float gradeInt = (float)grade;
            this.AddGrade(gradeInt);
        }

        public override void AddGrade(double grade)
        {
            float gradeDouble = (float)grade;
            this.AddGrade(gradeDouble);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Niepoprawna liczba");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades) 
            {
                statistics.AddGrade(grade);
            }
            
            return statistics;
        }
    }
}