namespace TestProjday7
{
    public class Tests
    {
        [Test]
        public void SumUsersPoints()
        {
            //arrange
            Employee user = new Employee("Piotr", "Cybulski", 30);
            user.Addpoints(4);
            user.Addpoints(7);
            //act
            int together = user.sum;
            //assert
            Assert.AreEqual(3, together);

        }
    }
}