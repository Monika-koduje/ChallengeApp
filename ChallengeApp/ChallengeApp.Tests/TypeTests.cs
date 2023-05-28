namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenTypeIsInt_ThenWeHaveValueType()
        {

            int age1 = 12;
            int age2 = 12;

            Assert.AreEqual(age1, age2);
        }

        [Test]
        public void WhenTypeIsObjectClass_ThenWeHaveReferenceType()
        {

            var age1 = Age("Monika", "B", 12);
            var age2 = Age("Kasia", "A", 12);


            Assert.AreEqual(age1.Age, age2.Age);

        }
        private Employee Age(string NewName, string NewSurname, int NewAge)
        {
            return new Employee(NewName, NewSurname, NewAge);
        }


    }
}
