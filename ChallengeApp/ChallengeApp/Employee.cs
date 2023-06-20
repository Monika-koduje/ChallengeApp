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
            if (point >= 0 && point <= 100)
            {
                this.points.Add(point);
            }
            else
            {
                Console.WriteLine("Invalid point value (wrong scope).");
            }
        }
        public void AddPoint(double point)
        {
            var doubleInFloatValue = (float)point;
            this.AddPoint(doubleInFloatValue);
        }
        public void AddPoint(decimal point)
        {
            var decimalInFloatValue = (float)point;
            this.AddPoint(decimalInFloatValue);
        }
        public void AddPoint(int point)
        {
            var intInFloatValue = (float)point;
            this.AddPoint(intInFloatValue);
        }
        public void AddPoint(long point)
        {
            var longInFloatValue = (float)point;
            this.AddPoint(longInFloatValue);
        }
        public void AddPoint(sbyte point)
        {
            var sbyteInFloatValue = (float)point;
            this.AddPoint(sbyteInFloatValue);
        }
        public void AddPoint(short point)
        {
            var shortInFloatValue = (float)point;
            this.AddPoint(shortInFloatValue);
        }
        public void AddPoint(uint point)
        {
            var uintInFloatValue = (float)point;
            this.AddPoint(uintInFloatValue);
        }
        public void AddPoint(ulong point)
        {
            var ulongInFloatValue = (float)point;
            this.AddPoint(ulongInFloatValue);
        }
        public void AddPoint(ushort point)
        {
            var ushortInFloatValue = (float)point;
            this.AddPoint(ushortInFloatValue);
        }
        public void AddPoint(byte point)
        {
            var byteInFloatValue = (float)point;
            this.AddPoint(byteInFloatValue);
        }
        public void AddPoint(string point)
        {
            if (float.TryParse(point, out float stringOkValue))
            {
                this.AddPoint(stringOkValue);
            }
            else
            {
                Console.WriteLine("Invalid point value (string is NaN).");
            }
        }
        public void AddPoint(char point)
        {
            switch (point)
            {
                case 'A':
                case 'a':
                    this.points.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.points.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.points.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.points.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.points.Add(20);
                    break;
                case 'F':
                case 'f':
                    this.points.Add(1);
                    break;
                default:
                    Console.WriteLine("Invalid point value (char is NaN).");
                    break;
            }
        }
        public void AddPoint(bool point)
        {
            if (point == true || point == false)
            {
                Console.WriteLine("Invalid point value (bool is NaN).");
            }
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

            switch (statistics.Average)
            {
                case var average when average >= 100:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 80:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'D';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'E';
                    break;
                case var average when average >= 1:
                    statistics.AverageLetter = 'F';
                    break;
                default:
                    Console.WriteLine("Not enough points");
                    break;
            }

            return statistics;
        }
    }

}



