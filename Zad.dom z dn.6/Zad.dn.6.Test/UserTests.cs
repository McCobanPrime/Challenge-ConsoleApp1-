namespace Zad.dn._6.Test;
using Employe;
public class Tests
{
    [Test]
    public void WhenEmployCollectPositiveScores()
    {
        //arrange
        var Employer = new Employee("Czes³aw", "Martyniuk", 56);
        //act
        Employer.AdddScore(6);
        Employer.AdddScore(4);
        Employer.AdddScore(7);
        //assert;
        Assert.AreEqual(17, Employer.Sum);
    }
    [Test]
    public void WhenEmployCollectNegativeScores()
    {
        //arrange
        var Employer = new Employee("Czes³aw", "Martyniuk", 56);
        //act
        Employer.AdddScore(-6);
        Employer.AdddScore(-4);
        Employer.AdddScore(-7);
        //assert;
        Assert.AreEqual(-17, Employer.Sum);
    }
    [Test]
    public void WhenEmployCollectDifirentScores_MustReturnZero_in_Result()
    {
        //arrange
        var Employer = new Employee("Czes³aw", "Martyniuk", 56);
        //act
        Employer.AdddScore(6);
        Employer.AdddScore(-4);
        Employer.AdddScore(7);
        Employer.AdddScore(-7);
        Employer.AdddScore(7);
        Employer.AdddScore(-9);
        //assert;
        Assert.AreEqual(0, Employer.Sum);
    }
}