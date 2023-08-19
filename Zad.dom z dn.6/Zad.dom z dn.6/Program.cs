using Employe;
Employee Employer1 = new Employee("Piotr", "Cybulski", 36);
Employee Employer2 = new Employee("Zuza", "Kowalska", 25);
Employee Employer3 = new Employee("Agnieszka", "Świderska", 40);

Employer1.AdddScore(4);
Employer1.AdddScore(3);
Employer1.AdddScore(7);
Employer1.AdddScore(9);
Employer2.AdddScore(5);
Employer2.AdddScore(6);
Employer2.AdddScore(1);
Employer2.AdddScore(7);
Employer3.AdddScore(3);
Employer3.AdddScore(1);
Employer3.AdddScore(4);
Employer3.AdddScore(8);

int TheBestScore = 0;
string NameBestEmployer = "-";
string SurNameBestEmployer = "-";

if (Employer1.Sum > Employer2.Sum && Employer1.Sum > Employer3.Sum)
{
    TheBestScore = Employer1.Sum;
    NameBestEmployer = Employer1.name;
    SurNameBestEmployer = Employer1.surname;
}
else if (Employer2.Sum > Employer1.Sum && Employer2.Sum > Employer3.Sum)
{
    TheBestScore = Employer2.Sum;
    NameBestEmployer = Employer2.name;
    SurNameBestEmployer = Employer2.surname;
}
else if (Employer3.Sum > Employer1.Sum && Employer3.Sum > Employer2.Sum)
{
    TheBestScore = Employer3.Sum;
    NameBestEmployer = Employer3.name;
    SurNameBestEmployer = Employer3.surname;
}

Console.WriteLine("Pracownik " + NameBestEmployer +" "+ SurNameBestEmployer + " Zdobył(a) najwiekszą ilość punktów.");
Console.WriteLine("Pracownik ten zdobył " + TheBestScore + " punkty.");
