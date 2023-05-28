namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetPoints_ShouldViewTheirScore()
        {
            var employee = new Employee("Monika", "A", 22);

            employee.AddPoint(2,3,5,6,3);

            var viewPoints = employee.ViewPoints;

            Assert.AreEqual(19, viewPoints);
        }

        [Test]
        public void WhenEmployeeGetMinusPoints_ShouldViewTheirScore()
        {
            var employee = new Employee("Monika", "A", 22);

            employee.AddPoint(2, -3, 5, 6, -3);
            employee.AddPoint(-2, 3, -5, -6, 3);


            var viewPoints = employee.ViewPoints;

            Assert.AreEqual(0, viewPoints);
        }


    }
}