﻿var name = "Ewa";
var sex = "Mężczyzna";
var age = 12;

if (sex == "Kobieta")
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, 33 lata");
    }

    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }

    else if (age > 30)
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }
    
}
else if (sex == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

else
{
    Console.WriteLine("Pełnoletni mężczyzna");
}
