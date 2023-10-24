var Name = "Ewa";
var Sex = "Kobieta";
var Age = 33;

if (Sex == "Kobieta" && Name == "Ewa" && Age == 33)
{
    Console.WriteLine("Ewa, 33 lat");
}
else if (Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (Age > 30)
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}
else if (Age < 30 || Sex != "Kobieta" || Name != "Ewa")
{
    Console.WriteLine("To nie jest Ewa");
}

if (Age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

else
{
    Console.WriteLine("Pełnoletni mężczyzna");
}





