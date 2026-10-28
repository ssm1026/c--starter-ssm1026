string signal = "CRIMSON";
string instructions;
switch (signal)
{
    case "CRIMSON":
    case "RED":
    case "SCARLET":
        instructions = "Evacuate Deck";
        break;
    case "YELLOW":
    case "AMBER":
        instructions = "Prepare Crew";
        break;
    case "GREEN":
        instructions = "No Emergency";
        break;
    default:
        instructions = "Unknown Signal";
        break;
}

Console.WriteLine(instructions);

// TODO: Lag switch med kombinerte case-labels.

