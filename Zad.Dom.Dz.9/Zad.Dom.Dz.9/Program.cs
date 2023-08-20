using Zad.Dom.Dz._9;

var emp = new Employee("Adam", "Gregorczyk");
emp.AddGrade(2);
emp.AddGrade(5);
emp.AddGrade(4);
var statistics = emp.GetStatistic();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
