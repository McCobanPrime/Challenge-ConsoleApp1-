namespace Zad.Dom.Dz._9.Test
{
    public class StatisticsTest
    {
        [Test]
        public void Test__IsThisTwoDiffirentEmployersHaveSameAverageValue()
        {
            //arrange
            var emp1 = new Employee("Adam","Gregorczyk");
            var emp2 = new Employee("Zenon","Brzêczyszczykiewicz");
            var statistics1 = emp1.GetStatistic();
            var statistics2 = emp2.GetStatistic();
            //act
            emp1.AddGrade(2);
            emp1.AddGrade(5);
            emp1.AddGrade(4);
            emp2.AddGrade(1);
            emp2.AddGrade(6);
            emp2.AddGrade(4);
            //assert
            Assert.AreEqual(statistics1.Average,statistics2.Average);
           
        }

        [Test]
        public void Test__IsThisTwoDiffirentEmployersHaveSameMaxValue()
        {
            //arrange
            var emp1 = new Employee("Adam", "Gregorczyk");
            var emp2 = new Employee("Zenon", "Brzêczyszczykiewicz");
            var statistics1 = emp1.GetStatistic();
            var statistics2 = emp2.GetStatistic();
            //act
            emp1.AddGrade(2);
            emp1.AddGrade(5);
            emp1.AddGrade(4);
            emp2.AddGrade(1);
            emp2.AddGrade(6);
            emp2.AddGrade(4);
            //assert
            Assert.AreEqual(statistics1.Max, statistics2.Max);

        }

        [Test]
        public void Test__IsThisTwoDiffirentEmployersHaveSameMinValue()
        {
            //arrange
            var emp1 = new Employee("Adam","Gregorczyk");
            var emp2 = new Employee("Zenon","Brzêczyszczykiewicz");
            var statistics1 = emp1.GetStatistic();
            var statistics2 = emp2.GetStatistic();
            //act
            emp1.AddGrade(2);
            emp1.AddGrade(5);
            emp1.AddGrade(4);
            emp2.AddGrade(1);
            emp2.AddGrade(6);
            emp2.AddGrade(4);
            //assert
            Assert.AreEqual(statistics1.Min, statistics2.Min);
        }
    }
}