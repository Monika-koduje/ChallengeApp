namespace ChallengeApp
{
    public class Employee
    {
        private List<float> points = new List<float>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
           
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public float ViewPoints
        {
            get
            {
                return this.points.Sum();
            }
        }

        public void AddPoint(float point)
        {
            this.points.Add(point);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var point in this.points)
            {
                statistics.Max = Math.Max(statistics.Max, point);
                statistics.Min = Math.Min(statistics.Min, point);
                statistics.Average += point;
            }

            statistics.Average /= this.points.Count;
            return statistics;

        }


    }
      

}

