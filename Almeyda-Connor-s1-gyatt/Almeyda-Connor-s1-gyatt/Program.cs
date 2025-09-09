// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Please choose a class (Type the number associated with it to select it):\n1. Fighter\n2. Mage ");

int Class = int.Parse(Console.ReadLine());
// Class Selection Code
if (Class == 1)
{ 
    Console.WriteLine("You chose Fighter. These are your stats");
    int Health =int.Parse("50");
    int Mana = int.Parse("20");
}

else if (Class == 2)
{
    
    Console.WriteLine("You chose Mage. These are your stats");
    int Health = int.Parse("25");
    int Mana = int.Parse("50");
}


else
{

    Console.WriteLine("You wish to be classless. Interesting...");
    int Health = int.Parse("30");
    int Mana = int.Parse("20");
}



