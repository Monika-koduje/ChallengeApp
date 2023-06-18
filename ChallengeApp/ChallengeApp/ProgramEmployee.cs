using ChallengeApp;

Employee employee = new Employee("Monika", "A", 22);

employee.AddPoint(3.33);
employee.AddPoint(3.3);
employee.AddPoint(3.9223372036854775808);
employee.AddPoint(5);
employee.AddPoint(500000000000000000);
employee.AddPoint(-128);
employee.AddPoint(-32.768);
employee.AddPoint(32767);
employee.AddPoint(3276700000);
employee.AddPoint(3276700000000000000);
employee.AddPoint(65535);
employee.AddPoint(255);
employee.AddPoint(true);
employee.AddPoint(false);
employee.AddPoint('p');
employee.AddPoint("Monika");

float viewPoints = employee.ViewPoints;

var statistics = employee.GetStatistics();

Console.WriteLine($"{employee.Name}'s total points: {viewPoints:N2}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: " + $"{statistics.Max}");