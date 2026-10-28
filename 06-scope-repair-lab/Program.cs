int signalStrength = 72;
string status;
if (signalStrength >= 70)
{
    status = "STRONG";
}
else
{
    status = "WEAK";
}

// TODO: Lag en løsning der status kan brukes etter if/else.

Console.WriteLine($"Signal status: {status}");
