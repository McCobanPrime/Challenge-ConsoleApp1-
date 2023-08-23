using Zad.Dom.Dz._10;
var emp = new Employee("Adam", "Gregorczyk");
emp.AddGrade(float.MaxValue);
emp.AddGrade(float.MinValue);

emp.AddGrade(double.MaxValue);
emp.AddGrade(double.MinValue);

emp.AddGrade(decimal.MaxValue);
emp.AddGrade(decimal.MinValue);

emp.AddGrade(int.MaxValue);
emp.AddGrade(int.MinValue);

emp.AddGrade(uint.MaxValue);
emp.AddGrade(uint.MinValue);

emp.AddGrade(long.MaxValue);
emp.AddGrade(long.MinValue);

emp.AddGrade(ulong.MaxValue);
emp.AddGrade(ulong.MinValue);

emp.AddGrade("-7");
emp.AddGrade("101");
emp.AddGrade('5');

emp.AddGrade('N');
emp.AddGrade("Mak");

emp.AddGrade(5);
emp.AddGrade(5);
emp.AddGrade(5);

var statistics = emp.GetStatistic();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");