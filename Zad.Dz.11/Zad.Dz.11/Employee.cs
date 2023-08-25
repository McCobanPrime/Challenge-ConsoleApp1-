namespace Zad.Dom.Dz._11
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid float value");
            }
        }
        public void AddGrade(double grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                float NewGrade = (float)grade;
                this.grades.Add(NewGrade);
            }
            else
            {
                Console.WriteLine("Invalid double value");
            }
        }
        public void AddGrade(decimal grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                float NewGrade = (float)grade;
                this.grades.Add(NewGrade);
            }
            else
            {
                Console.WriteLine("Invalid decimal value");
            }
        }
        public void AddGrade(int grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                float NewGrade = (float)grade;
                this.grades.Add(NewGrade);
            }
            else
            {
                Console.WriteLine("Invalid int value");
            }
        }
        public void AddGrade(uint grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                float NewGrade = (float)grade;
                this.grades.Add(NewGrade);
            }
            else
            {
                Console.WriteLine("Invalid uint value");
            }
        }
        public void AddGrade(long grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                float NewGrade = (float)grade;
                this.grades.Add(NewGrade);
            }
            else
            {
                Console.WriteLine("Invalid long value");
            }
        }
        public void AddGrade(ulong grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                float NewGrade = (float)grade;
                this.grades.Add(NewGrade);
            }
            else
            {
                Console.WriteLine("Invalid ulong value");
            }
        }

        public void AddGrade(char grade)
        {
            string Grade = grade.ToString();
            if (float.TryParse(Grade, out float result))
            {
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("Char is not a number. You must use numbers");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {

                if (result >= 0 && result <= 100)
                {
                    this.grades.Add(result);
                }
                else if (result < 0)
                {
                    Console.WriteLine("Too small value in the string");
                }
                else if (result > 100)
                {
                    Console.WriteLine("String value too large");
                }
            }
            else
            {
                Console.WriteLine("String is not a number. You must use numbers");
            }
        }

        public Statistics GetStatisticWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average = statistics.Average + grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;

        }
        public Statistics GetStatisticWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = 0;
            statistics.Min = float.MaxValue;

            for (int grade = 0; grade < this.grades.Count; grade++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Average = statistics.Average + this.grades[grade];
            }
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = 0;
            statistics.Min = float.MaxValue;
            int grade = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Average = statistics.Average + this.grades[grade];
                grade++;
            }
            while (grade < this.grades.Count);

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = 0;
            statistics.Min = float.MaxValue;
            int grade = 0;
            while (grade < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Average = statistics.Average + this.grades[grade];
                grade++;
            }
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
    }

}