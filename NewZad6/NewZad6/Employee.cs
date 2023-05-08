namespace NewZad6
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public List<int> points = new List<int>();
        public void Addpoints(int point)
        {
            this.points.Add(point);
        }
        public int Sum
        {
            get
            {
                return this.points.Sum();
            }
        }
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
    }
}

