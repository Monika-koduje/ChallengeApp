namespace ChallengeApp
{
    class Employee
    {
        private List<int> points = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int ViewPoints
        {
            get
            {
                return this.points.Sum();
            }
        }

        public void AddPoint(int point1, int point2, int point3, int point4, int point5)
        {
            this.points.Add(point1 + point2 + point3 + point4 + point5);
        }

    }

}

