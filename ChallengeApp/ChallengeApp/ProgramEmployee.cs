using ChallengeApp;
using System.Security.Cryptography.X509Certificates;

string title = "program great employee";
Console.WriteLine($"\n {title.ToUpper()}\n");
Console.WriteLine(" Welcome to the Employee grade system");
Console.WriteLine("......................................\n");

Console.WriteLine("\n Submit Employee information\n");

string nameOkEmployee;
string nameOkSupervisor;
string surnameOkEmployee;
string surnameOkSupervisor;
int ageOkEmployee;
int ageOkSupervisor;

while (true)
{
    Console.WriteLine(" Employee's name:");
    string name = Console.ReadLine();

    try
    {
        if (int.TryParse(name, out int nameIsWrongInt) || float.TryParse(name, out float nameIsWrongFloat))
        {
            throw new Exception("Invalid string value (wrong name)");
        }
        else if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Invalid string value (name not given)");
        }
        else
        {
            nameOkEmployee = name;
            break;
        }
    }
    catch (Exception error)
    {
        Console.WriteLine($"\nException catched:\n{error.Message}\n");
    }
}




while (true)
{
    Console.WriteLine(" Employee's surname:");
    string surname = Console.ReadLine();

    try
    {
        if (int.TryParse(surname, out int surnameIsWrongInt) || float.TryParse(surname, out float surnameIsWrongFloat))
        {
            throw new Exception("Invalid string value (wrong surname)");
        }
        else if (string.IsNullOrEmpty(surname))
        {
            throw new Exception("Invalid string value (surname not given)");
        }
        else
        {
            surnameOkEmployee = surname;
            break;
        }
    }
    catch (Exception error)
    {
        Console.WriteLine($"\nException catched:\n{error.Message}\n");
    }
}

while (true)
{
    Console.WriteLine(" Employee's age:");
    var age = Console.ReadLine();

    try
    {
        if (int.TryParse(age, out int stringAgeOkValue))
        {
            if (stringAgeOkValue >= 18 && stringAgeOkValue <= 150)
            {
                ageOkEmployee = stringAgeOkValue;
                break;
            }
            else
            {
                throw new Exception("Invalid age value (wrong scope)");
            }
        }
        else
        {
            throw new Exception("Invalid age value (string is NaN).");
        }
    }
    catch (Exception error)
    {
        Console.WriteLine($"\nException catched:\n{error.Message}\n");
    }
}


while (true)
{
    Console.WriteLine(" Supervisor's name:");
    string name = Console.ReadLine();

    try
    {
        if (int.TryParse(name, out int nameIsWrongInt) || float.TryParse(name, out float nameIsWrongFloat))
        {
            throw new Exception("Invalid string value (wrong name)");
        }
        else if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Invalid string value (name not given)");
        }
        else
        {
            nameOkSupervisor = name;
            break;
        }
    }
    catch (Exception error)
    {
        Console.WriteLine($"\nException catched:\n{error.Message}\n");
    }
}

while (true)
{
    Console.WriteLine(" Supervisor's surname:");
    string surname = Console.ReadLine();

    try
    {
        if (int.TryParse(surname, out int surnameIsWrongInt) || float.TryParse(surname, out float surnameIsWrongFloat))
        {
            throw new Exception("Invalid string value (wrong surname)");
        }
        else if (string.IsNullOrEmpty(surname))
        {
            throw new Exception("Invalid string value (surname not given)");
        }
        else
        {
            surnameOkSupervisor = surname;
            break;
        }
    }
    catch (Exception error)
    {
        Console.WriteLine($"\nException catched:\n{error.Message}\n");
    }
}

while (true)
{
    Console.WriteLine(" Supervisor's age:");
    var age = Console.ReadLine();

    try
    {
        if (int.TryParse(age, out int stringAgeOkValue))
        {
            if (stringAgeOkValue >= 18 && stringAgeOkValue <= 150)
            {
                ageOkSupervisor = stringAgeOkValue;
                break;
            }
            else
            {
                throw new Exception("Invalid age value (wrong scope)");
            }
        }
        else
        {
            throw new Exception("Invalid age value (string is NaN).");
        }
    }
    catch (Exception error)
    {
        Console.WriteLine($"\nException catched:\n{error.Message}\n");
    }
}

Employee employee = new Employee(nameOkEmployee, surnameOkEmployee, ageOkEmployee);

Supervisor employeeSupervisor = new Supervisor(nameOkSupervisor, surnameOkSupervisor, ageOkSupervisor);

while (true)
{
    Console.WriteLine(" Employee's point: (press q and enter to quit)");
    var pointEmployee = Console.ReadLine();

    if (pointEmployee == "q")
    {
        break;
    }

    try
    {
        employee.AddPoint(pointEmployee);
    }
    catch (Exception error)
    {
        Console.WriteLine($"\nException catched:\n{error.Message}\n");
    }
}

while (true)
{
    Console.WriteLine(" Supervisor's point: (press q and enter to quit)");
    var pointSpervisor = Console.ReadLine();

    if (pointSpervisor == "q")
    {
        break;
    }

    try
    {
        employeeSupervisor.AddPoint(pointSpervisor);
    }
    catch (Exception error)
    {
        Console.WriteLine($"\nException catched:\n{error.Message}\n");
    }
}

float viewPoints = employee.ViewPoints;
var statistics = employee.GetStatistics();

float viewPointsSupervisor = employeeSupervisor.ViewPoints;
var statisticsSupervisor = employeeSupervisor.GetStatistics();

Console.WriteLine($"\n\n Employee ({employee.Name} {employee.Surname} age: {employee.Age}) data sheet:");
Console.WriteLine($"\n {employee.Name}'s total points: {viewPoints:N2}");
Console.WriteLine($" Min: {statistics.Min}");
Console.WriteLine($" Max: {statistics.Max}");
Console.WriteLine($" Average: {statistics.Average:N2}");
Console.WriteLine($" Letter grade: {statistics.AverageLetter}");

Console.WriteLine($"\n\n Supervisor ({employeeSupervisor.Name} {employeeSupervisor.Surname} age: {employeeSupervisor.Age}) data sheet:");
Console.WriteLine($"\n {employeeSupervisor.Name}'s total points: {viewPointsSupervisor:N2}");
Console.WriteLine($" Min: {statisticsSupervisor.Min}");
Console.WriteLine($" Max: {statisticsSupervisor.Max}");
Console.WriteLine($" Average: {statisticsSupervisor.Average:N2}");
Console.WriteLine($" Letter grade: {statisticsSupervisor.AverageLetter}");


