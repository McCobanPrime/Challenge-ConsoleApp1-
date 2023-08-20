namespace Zad.dn._6.Test;
using Employe;
internal class TypeTests
{
    [Test]
    public void TestForStringReferenceType()
    {
        //arrange
        string number1 = "Piotr";
        string number2 = "Marek";
        //act

        //assert;
        Assert.AreNotEqual(number1, number2);
    }

    [Test]
    public void TestForIntValueType()
    {
        //arrange
        int number1 = 1;
        int number2 = 1;
        //act

        //assert;
        Assert.AreEqual(number1, number2);
    }
    [Test]
    public void TestForFloatValueType()
    {
        //arrange
        float number1 = 1;
        float number2 = 1;
        //act

        //assert;
        Assert.AreEqual(number1, number2);
    }
    [Test]
    public void TestForEmployeeReferenceType()
    {
        //arrange
        var Employer1 = new Employee("Czesław", "Martyniuk", 56);
        var Employer2 = new Employee("Zenon", "Kowalski", 30);
        //act

        //assert;
        Assert.AreNotEqual(Employer1, Employer2);
    }
    private Employee GetEmploye(string name, string surname, int age)
    {
        return new Employee(name, surname, age);
    }
}
