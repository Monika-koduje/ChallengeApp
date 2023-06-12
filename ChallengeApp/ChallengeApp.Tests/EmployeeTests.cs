namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetPoints_ShouldViewTheirScore()
        {
            var employee = new Employee("Monika", "A", 22);

            employee.AddPoint(2);
            employee.AddPoint(5);

            var viewPoints = employee.ViewPoints;

            Assert.AreEqual(7, viewPoints);
        }

        [Test]
        public void WhenEmployeeGetMinusPoints_ShouldViewTheirScore()
        {
            var employee = new Employee("Monika", "A", 22);

            employee.AddPoint(2);
            employee.AddPoint(-2);


            var viewPoints = employee.ViewPoints;

            Assert.AreEqual(0, viewPoints);
        }


    }
}