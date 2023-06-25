using System.Security.Cryptography;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> pointsSupervisor = new List<float>();

        public Supervisor(string name, string surname, int age)
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
                return this.pointsSupervisor.Sum();
            }
        }

        public void AddPoint(float point)
        {
            if (point >= 0 && point <= 100)
            {
                this.pointsSupervisor.Add(point);
            }
            else
            {
                throw new Exception("Invalid point value (wrong scope).");
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
                switch (point)
                {
                    case "6":
                        this.pointsSupervisor.Add(100);
                        break;
                    case "-6":
                    case "6-":
                        this.pointsSupervisor.Add(95);
                        break;
                    case "+5":
                    case "5+":
                        this.pointsSupervisor.Add(85);
                        break;
                    case "5":
                        this.pointsSupervisor.Add(80);
                        break;
                    case "-5":
                    case "5-":
                        this.pointsSupervisor.Add(75);
                        break;
                    case "+4":
                    case "4+":
                        this.pointsSupervisor.Add(65);
                        break;
                    case "4":
                        this.pointsSupervisor.Add(60);
                        break;
                    case "-4":
                    case "4-":
                        this.pointsSupervisor.Add(55);
                        break;
                    case "+3":
                    case "3+":
                        this.pointsSupervisor.Add(45);
                        break;
                    case "3":
                        this.pointsSupervisor.Add(40);
                        break;
                    case "-3":
                    case "3-":
                        this.pointsSupervisor.Add(35);
                        break;
                    case "2+":
                    case "+2":
                        this.pointsSupervisor.Add(25);
                        break;
                    case "2":
                        this.pointsSupervisor.Add(20);
                        break;
                    case "-2":
                    case "2-":
                        this.pointsSupervisor.Add(15);
                        break;
                    case "+1":
                    case "1+":
                        this.pointsSupervisor.Add(5);
                        break;
                    case "1":
                        this.pointsSupervisor.Add(0);
                        break;
                    default:
                        throw new Exception("Invalid point value (string is NaN or wrong scope, acceptable from 1 to 6).");
                }
            }
        }
        public void AddPoint(char point)
        {
            throw new Exception("Invalid point value (char is NaN).");
        }

        public void AddPoint(bool point)
        {
            if (point == true || point == false)
            {
                throw new Exception("Invalid point value (bool is NaN).");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var point in this.pointsSupervisor)
            {
                statistics.Max = Math.Max(statistics.Max, point);
                statistics.Min = Math.Min(statistics.Min, point);
                statistics.Average += point;
            }

            statistics.Average /= this.pointsSupervisor.Count;

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
                    throw new Exception("Not enough points");
            }

            return statistics;
        }
    }
}
