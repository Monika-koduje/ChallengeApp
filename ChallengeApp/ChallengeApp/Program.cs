string name = "Monika";
bool female = true;
int age = 100;

if (female && age > 30)
{
    Console.WriteLine(name + "," + " " + "lat" + " " + age);
}
else if (!female && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}


