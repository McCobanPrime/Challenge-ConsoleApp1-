using Zad.Dom.Dz._11;

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

var statistics1 = emp.GetStatisticWithForEach();
var statistics2 = emp.GetStatisticWithFor();
var statistics3 = emp.GetStatisticWithDoWhile();
var statistics4 = emp.GetStatisticWithWhile();
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");

