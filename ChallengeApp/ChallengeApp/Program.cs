string name = "Monika";
bool female = true;
int age = 100;

if (female && age > 30)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine(name + "," + " " + "lat" + " " + age);
    }
}
else if (!female)
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni Mężczyzna");
    }
}
else
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}


