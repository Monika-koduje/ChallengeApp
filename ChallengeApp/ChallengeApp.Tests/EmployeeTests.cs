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

            Assert.AreEqual(2, viewPoints);
        }

        [Test]
        public void WhenEmployeeGetStatistics_ShouldViewTheirCorrectStatisctics()
        {
            var employee = new Employee("Monika", "A", 22);

            employee.AddPoint(2);
            employee.AddPoint(3);
            employee.AddPoint(8);


            var statistics = employee.GetStatistics();

            Assert.AreEqual("4,33", $"{statistics.Average:N2}");
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void WhenEmployeeGetRightPoints_ShouldViewTheirGradeLetter()
        {
            var employee = new Employee("Monika", "A", 22);

            employee.AddPoint(20);
            employee.AddPoint(36);
            employee.AddPoint(84);


            var statistics = employee.GetStatistics();

            Assert.AreEqual('D', statistics.AverageLetter);
        }
    }

}
