Employee user1 = new Employee("Piotr", "Cybulski", 30);
Employee user2 = new Employee("Roman", "Romanowicz", 27);
Employee user3 = new Employee("Gosia", "Samosia", 33);

user1.Addpoints(3);
user1.Addpoints(5);
user1.Addpoints(7);
user1.Addpoints(9);
user1.Addpoints(3);

user2.Addpoints(3);
user2.Addpoints(8);
user2.Addpoints(7);
user2.Addpoints(2);
user2.Addpoints(1);

user3.Addpoints(1);
user3.Addpoints(9);
user3.Addpoints(5);
user3.Addpoints(2);
user3.Addpoints(4);

string winner = "-";
int winnerSpoints = 0;

if (user1.sum > user2.sum && user1.sum > user3.sum)
{
    winner = user1.age + " lat " + user1.name + " " + user1.surname;
    winnerSpoints = user1.sum;
}
else if (user2.sum > user1.sum && user2.sum > user3.sum)
{
    winner = user2.age + " lat " + user2.name + " " + user2.surname;
    winnerSpoints = user2.sum;
}
else if (user3.sum > user2.sum && user3.sum > user1.sum)
{
    winner = user3.age + " lat " + user3.name + " " + user3.surname;
    winnerSpoints = user3.sum;
}

Console.WriteLine("Użytkownik " + user1.name + " zdobył " + user1.sum + " punktów.");
Console.WriteLine("Użytkownik " + user2.name + " zdobył " + user2.sum + " punktów.");
Console.WriteLine("Użytkownik " + user3.name + " zdobył " + user3.sum + " punktów.");
Console.WriteLine("Oczywiście że zwyciężcą zostaje mający " + winner + ", zdobywając " + winnerSpoints + " punktów.");

class Employee
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