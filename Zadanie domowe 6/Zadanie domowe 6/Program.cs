Employee user1 = new Employee("Piotr","Cybulski",30); 
Employee user2 = new Employee("Roman","Romanowicz",27);
Employee user3 = new Employee("Gosia","Samosia",33);

List<int> points1 = new List<int>();
List<int> points2 = new List<int>();
List<int> points3 = new List<int>();

int suma1 = 0;
int suma2 = 0;
int suma3 = 0;

user1.points = points1;
points1.Add(3);
points1.Add(5);
points1.Add(7);
points1.Add(9);
points1.Add(3);
for (int i = 0; i < points1.Count; i++)
{
    suma1 = suma1 + points1[i];
}

user2.points = points2;
points2.Add(3);
points2.Add(8);
points2.Add(7);
points2.Add(2);
points2.Add(1);
for (int i = 0; i < points2.Count; i++)
{
    suma2 = suma2 + points2[i];
}

user3.points = points3;
points3.Add(1);
points3.Add(9);
points3.Add(5);
points3.Add(2);
points3.Add(4);
for (int i = 0; i < points3.Count; i++)
{
    suma3 = suma3 + points3[i];
}
string zwyciężca = "-";
int punktyZwyciężcy = 0;

if (suma1>suma2&&suma1>suma3)
{
    zwyciężca = user1.age + " lat " + user1.name + " " + user1.surname;
    punktyZwyciężcy = suma1;
}
else if(suma2>suma1&&suma2>suma3)
{
    zwyciężca = user2.age + " lat " + user2.name + " " + user2.surname;
    punktyZwyciężcy = suma2;
}
else if (suma3 > suma2 && suma3 > suma1)
{
    zwyciężca = user3.age + " lat "+user3.name+ " " +user3.surname;
    punktyZwyciężcy = suma3;
}



Console.WriteLine("Użytkownik " + user1.name + " zdobył " + suma1 + " punktów.");
Console.WriteLine("Użytkownik " + user2.name + " zdobył " + suma2 + " punktów.");
Console.WriteLine("Użytkownik " + user3.name + " zdobył " + suma3 + " punktów.");
Console.WriteLine("Oczywiście że zwyciężcą zostaje mający " + zwyciężca + ", zdobywając " + punktyZwyciężcy + " punktów.");
class Employee
{
    public string name;
    public string surname;
    public int age;
    public List<int> points = new List<int>();

    public Employee(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }
}
