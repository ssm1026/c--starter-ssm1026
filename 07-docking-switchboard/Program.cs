string dockingCode = "CLOSED";
string instruction;
switch (dockingCode)
{
    case "NORTH":
        instruction = "Dock at gate 1";
        break;
    case "EAST":
        instruction = "Dock at gate 2";
        break;
    case "SERVICE":
        instruction = "Dock at maintenance bay";
        break;
    case "CLOSED":
        instruction = "Hold Position";
        break;
    default:
        instruction = "Unknown docking code";
        break;
}
instruction = $"{instruction}";

// TODO: Bruk switch statement til å sette instruction.

Console.WriteLine(instruction);
