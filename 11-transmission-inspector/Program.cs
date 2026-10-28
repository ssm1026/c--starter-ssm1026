string transmission = "CLEAR";
int interferenceCount = 0;
char symbol = '#';

foreach (char c in transmission)
{
    if (c == symbol)
    {
        interferenceCount++;
    }
}

// TODO: Bruk foreach over transmission.

Console.WriteLine($"Interference markers: {interferenceCount}");
