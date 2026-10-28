int charge = 23;
int drainPerCycle = 5;

while (charge > 0)
{
    Console.WriteLine(charge);
    charge -= drainPerCycle;
}

// TODO: Bruk while til å simulere utladingen.

Console.WriteLine("Power cell offline.");
