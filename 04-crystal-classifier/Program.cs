int energy = 130;
string classification = "";

// TODO: Sett classification med if / else if / else.
if (energy < 20)
{
    classification = "Dormant";
}
else if (energy <= 49)
{
    classification = "Stable";
}    
else if (energy <= 79)
{
    classification = "Unstable";
}
else
{
    classification = "Critical";
}
Console.WriteLine($"Classification: {classification}");
