namespace Zad_domowe_6
{
    public class Employee
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

        public List<int> points = new List<int>();
        public void Addpoints(int point)
        {
            this.points.Add(point);
        }
        public int sum
        {
            get
            {
                return this.points.Sum();
            }
        }
        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }
}
