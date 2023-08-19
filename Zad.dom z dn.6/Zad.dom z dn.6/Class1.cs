namespace Employe;

public class Employee
{
    public string name;
    public string surname;
    public int age;
    List<int> points = new List<int>();

    public Employee(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }
    public void AdddScore(int number)
    {
        this.points.Add(number);
    }
    public int Sum
    {
        get
        {
            return this.points.Sum();
        }
    }
}
