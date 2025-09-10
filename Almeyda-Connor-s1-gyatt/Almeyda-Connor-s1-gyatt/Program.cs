// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Please choose a class (Type the number associated with it to select it):\n1. Fighter\n2. Mage ");
int Health = int.Parse("30");
int Mana = int.Parse("20");
int Class = int.Parse(Console.ReadLine());
// Class Selection Code
if (Class == 1)
{ 
    Console.WriteLine("You chose Fighter. These are your stats");
    Health =50;
    Mana = 20;
    Console.WriteLine($"Health: {Health}");
    Console.WriteLine($"Mana: {Mana}");
    Console.WriteLine("Sword (1)");
    Console.WriteLine("Bow (2)");
    Console.WriteLine("Shield Bash (3)");
    Console.WriteLine("First Aid (4)");
}

else if (Class == 2)
{
    
    Console.WriteLine("You chose Mage. These are your stats");
    Health = 25;
    Mana = 50;
    Console.WriteLine($"Health: {Health}");
    Console.WriteLine($"Mana: {Mana}");
    Console.WriteLine("Knife (1)");
    Console.WriteLine("Fireball (2)");
    Console.WriteLine("Cure (3)");
    Console.WriteLine("Shield (4)");
}


else
{

    Console.WriteLine("You wish to be classless. Interesting...");
    Console.WriteLine($"Health: {Health}");
    Console.WriteLine($"Mana: {Mana}");
    Console.WriteLine("Knife (1)");
    Console.WriteLine("Apple (2)");
    Console.WriteLine("Poop (3)");
    Console.WriteLine("Run (4)");
}
//Command Script
Console.WriteLine("Now, try using an ability against this training dummy (Type the number associated with a command)");
int Command = int.Parse(Console.ReadLine());
if (Class == 1)
{
    if (Command == 1)
        Console.WriteLine("You slash with your sword against the training dummy, slashing the back of it, breaking it.");
    else if (Command == 2)
        Console.WriteLine("You shoot an arrow at the training dummy, knocking its head clean off.");
    else if (Command == 3)
        Console.WriteLine("You bash your shield into the training dummy, knocking it over.");
    else if (Command == 4)
        Console.WriteLine("You take out some bandaids, healing a paper cut you got earlier that day. The training dummy, unprepared with its own, runs away.");
    else Console.WriteLine("Really? That's not on the list dude. You sh*t yourself as punishment.");
}

else if (Class == 2)
{

    if (Command == 1)
        Console.WriteLine("You stab the dummy with your knife, sinking deep into it's hay bale chest. It falls over from the impact.");
    else if (Command == 2)
        Console.WriteLine("You shoot off a fireball, incinerating the training dummy in front of you. Only ash remains of it.");
    else if (Command == 3)
        Console.WriteLine("You command the forces of nature to restore yourself. The training dummy is intimidated by your command of primordial forces and runs away.");
    else if (Command == 4)
        Console.WriteLine("You manifest a barrier around yourself, as the training dummy attempts a stick attack against you, which fails to penitrate it. The training dummy, unsure what to do now, runs away.");
    else Console.WriteLine("Really? That's not on the list dude. You sh*t yourself as punishment.");
}


else
{

    if (Command == 1)
        Console.WriteLine("You stab the dummy with your knife, failing to penatrate it as you don't have any strength to do so. The training dummy then uses a stick attack, killing you instantly");
    else if (Command == 2)
        Console.WriteLine("You eat an apple. It is delicious. The Training Dummy then hits you with its stick, killing you instantly");
    else if (Command == 3)
        Console.WriteLine("You soil your pants in fear. You die of hermeroids.");
    else if (Command == 4)
        Console.WriteLine("You successfully run away. However, the training dummy still lives. In a way, you have failed at the first step on your adventure because you decided to not pick any of the classes I presented to you. Congrats. Did you have fun?");
    else Console.WriteLine("Really? That's not on the list dude. You sh*t yourself as punishment.");
}






