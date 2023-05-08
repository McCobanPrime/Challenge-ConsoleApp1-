namespace TestProj6.Zad7
{
    public class Tests
    {
        [Test]
        public void TestDidClassWorkRight()
        {
            //arrange
            var user = new Employee("Rafa³", "Cybulski", 25);
            user.Addpoints(4);
            user.Addpoints(7);
            //act
            var together = user.Sum;
            //assert
            Assert.AreEqual(11, together);
        }
    }
}