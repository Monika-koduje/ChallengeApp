using ChallengeApp;

Employee employee = new Employee("Monika", "A", 22);

employee.AddPoint(5);
employee.AddPoint(1);
employee.AddPoint(8);

float viewPoints = employee.ViewPoints;

var statistics = employee.GetStatistics();

Console.WriteLine($"{employee.Name}'s total points: {viewPoints}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");