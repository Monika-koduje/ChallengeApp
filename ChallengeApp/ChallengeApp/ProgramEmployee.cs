using ChallengeApp;

string title = "program great employee";
Console.WriteLine($"\n {title.ToUpper()}\n");
Console.WriteLine(" Welcome to the Employee grade system");
Console.WriteLine("......................................\n");

Console.WriteLine("\n Submit Employee information\n");

string nameOk = " ";

while (true)
{
    Console.WriteLine(" Employee's name:");
    string name = Console.ReadLine();

    if (int.TryParse(name, out int nameIsWrongInt) || float.TryParse(name, out float nameIsWrongFloat))
    {
        Console.WriteLine("\nError: Invalid string value (wrong name)");
    }
    else if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("\nError: Invalid string value (name not given)");
    }
    else
    {
        nameOk = name;
        break;
    }
}

string surnameOk = " ";

while (true)
{
    Console.WriteLine(" Employee's surname:");
    string surname = Console.ReadLine();

    if (int.TryParse(surname, out int surnameIsWrongInt) || float.TryParse(surname, out float surnameIsWrongFloat))
    {
        Console.WriteLine("\nError: Invalid string value (wrong surname)");
    }
    else if (string.IsNullOrEmpty(surname))
    {
        Console.WriteLine("\nError: Invalid string value (surname not given)");
    }
    else
    {
        surnameOk = surname;
        break;
    }
}

int ageOk = 0;

while (true)
{
    Console.WriteLine(" Employee's age:");
    var age = Console.ReadLine();

    if (int.TryParse(age, out int stringAgeOkValue))
    {
        if (stringAgeOkValue >= 18 && stringAgeOkValue <= 150)
        {
            ageOk = stringAgeOkValue;
            break;
        }
        else
        {
            Console.WriteLine("\nErorr: Invalid age value (wrong scope)");
        }
    }
    else
    {
        Console.WriteLine("\nError: Invalid age value (string is NaN).");
    }
}

Employee employee = new Employee(nameOk, surnameOk, ageOk);

while (true)
{
    Console.WriteLine("Employee's point: (press q and enter to quit)");
    var pointEmployee = Console.ReadLine();

    if (pointEmployee == "q")
    {
        break;
    }
    employee.AddPoint(pointEmployee);
}

float viewPoints = employee.ViewPoints;
var statistics = employee.GetStatistics();

Console.WriteLine($"\n\n Employee ({employee.Name} {employee.Surname} age: {employee.Age}) data sheet:");
Console.WriteLine($"\n {employee.Name}'s total points: {viewPoints:N2}");
Console.WriteLine($" Min: {statistics.Min}");
Console.WriteLine($" Max: {statistics.Max}");
Console.WriteLine($" Average: {statistics.Average:N2}");
Console.WriteLine($" Letter grade: {statistics.AverageLetter}");
