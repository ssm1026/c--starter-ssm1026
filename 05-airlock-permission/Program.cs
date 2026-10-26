bool hasSuit = true;
int oxygenPercent = 44;
int pressure = 101;
bool alarmActive = !true;

// TODO: Kombiner alle kravene i ett logisk uttrykk.
bool canOpenAirlock = hasSuit && oxygenPercent > 30 && pressure >= 90 && pressure <= 110 && alarmActive;

if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
