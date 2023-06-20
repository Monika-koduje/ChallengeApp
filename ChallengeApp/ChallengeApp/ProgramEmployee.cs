using ChallengeApp;

Employee employee = new Employee("Monika", "A", 22);

Console.WriteLine("Errors: (...)\n");

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
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("\n\nStatistics with ForEach:");
Console.WriteLine($"\n{employee.Name}'s total points: {viewPoints:N2}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("\n\nStatistics with For:");
Console.WriteLine($"\n{employee.Name}'s total points: {viewPoints:N2}");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine("\n\nStatistics with Do-While:");
Console.WriteLine($"\n{employee.Name}'s total points: {viewPoints:N2}");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine("\n\nStatistics with While:");
Console.WriteLine($"\n{employee.Name}'s total points: {viewPoints:N2}");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");

Console.WriteLine("\n\nIf statistics with \n> For, \n> Do-While, \n> While\nare the same like \n> ForEach (their values),\nthen var \n> statistics2, \n> statistics3, \n> statistics4 \nare correct (proper values var statistics).\n\n");
