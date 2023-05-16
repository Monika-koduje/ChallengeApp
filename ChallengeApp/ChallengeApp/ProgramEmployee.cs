using ChallengeApp;

Employee employee1 = new Employee("Monika", "A", 22);
Employee employee2 = new Employee("Dawid", "B", 22);
Employee employee3 = new Employee("Przemek", "C", 18);

employee1.AddPoint(1, 2, 3, 4, 5);
employee2.AddPoint(1, 3, 4, 2, 10);
employee3.AddPoint(10, 8, 6, 9, 5);

int viewPoints1 = employee1.ViewPoints;
int viewPoints2 = employee2.ViewPoints;
int viewPoints3 = employee3.ViewPoints;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

IEnumerable<int> maxScoreValue = from employee in employees select employee.ViewPoints;

var maxPerson = maxScoreValue.Max();

int maxPoints = maxPerson;
Employee personWithTopPoints = null;

foreach (var employee in employees)
{
  if (employee.ViewPoints == maxPoints)
  {
        personWithTopPoints = employee;
  }
}

Console.WriteLine(" Punkty pracowników:\n");

Console.WriteLine(" " + employee1.Name + " " + employee1.Surname + " = " + viewPoints1);
Console.WriteLine(" " + employee2.Name + " " + employee2.Surname + " = " + viewPoints2); 
Console.WriteLine(" " + employee3.Name + " " + employee3.Surname + " = " + viewPoints3);

Console.WriteLine("\n Pracownik z najwyższą liczbą punktów: " + personWithTopPoints.Name + "!");
