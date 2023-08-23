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
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Average = statistics1.Average + grade;
            }
            statistics1.Average = statistics1.Average / this.grades.Count;
            return statistics1;

        }
        public Statistics GetStatisticWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = 0;
            statistics2.Min = float.MaxValue;

            for (int grade = 0; grade < this.grades.Count; grade++)
            {
                statistics2.Max = Math.Max(statistics2.Max, this.grades[grade]);
                statistics2.Min = Math.Min(statistics2.Min, this.grades[grade]);
                statistics2.Average = statistics2.Average + this.grades[grade];
            }
            statistics2.Average = statistics2.Average / this.grades.Count;
            return statistics2;
        }
        public Statistics GetStatisticWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = 0;
            statistics3.Min = float.MaxValue;
            int grade = 0;
            do
            {
                statistics3.Max = Math.Max(statistics3.Max, this.grades[grade]);
                statistics3.Min = Math.Min(statistics3.Min, this.grades[grade]);
                statistics3.Average = statistics3.Average + this.grades[grade];
                grade++;
            }
            while (grade < this.grades.Count);

            statistics3.Average = statistics3.Average / this.grades.Count;
            return statistics3;
        }
        public Statistics GetStatisticWithWhile()
        {
            var statistics4 = new Statistics();
            statistics4.Average = 0;
            statistics4.Max = 0;
            statistics4.Min = float.MaxValue;
            int grade = 0;
            while (grade < this.grades.Count)
            {
                statistics4.Max = Math.Max(statistics4.Max, this.grades[grade]);
                statistics4.Min = Math.Min(statistics4.Min, this.grades[grade]);
                statistics4.Average = statistics4.Average + this.grades[grade];
                grade++;
            }
            statistics4.Average = statistics4.Average / this.grades.Count;
            return statistics4;
        }
    }

}