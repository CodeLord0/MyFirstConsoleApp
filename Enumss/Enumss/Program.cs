// See https://aka.ms/new-console-template for more information

ChestState current = ChestState.locked;
string Input;

while (true)
{
//chest is locked
    if (current == ChestState.locked)
    {
        System.Console.WriteLine("the chest is locked");
        Console.Write("What do you want to do: ");
        Input = Console.ReadLine();

        if (Input == "unlock")
        {
            current = ChestState.unlocked;
        }

    }
//chest is unlocked
    if (current == ChestState.unlocked)
    {
        System.Console.WriteLine("the chest is unlocked");
        Console.Write("What do you want to do: ");
        Input = Console.ReadLine();

        if (Input == "lock")
        {
            current = ChestState.locked;
        }
        else if (Input == "open")
        {
            current = ChestState.opened;
        }
    }
//chest is locked
    if (current == ChestState.locked)
    {
        System.Console.WriteLine("the chest is locked");
        Console.Write("What do you want to do: ");
        Input = Console.ReadLine();

        if (Input == "unlock")
        {
            current = ChestState.unlocked;
        }
    }
//chest is opened
    if (current == ChestState.opened)
    {
        System.Console.WriteLine("the chest is opened");
        Console.Write("What do you want to do: ");
        Input = Console.ReadLine();

        if (Input == "close")
        {
            current = ChestState.closed;
        }
    }
    // chest is closed
    if (current == ChestState.closed)
    {
        System.Console.WriteLine("the chest is closedo");
        Console.Write("What do you want to do: ");
        Input = Console.ReadLine();

        if (Input == "open")
        {
            current = ChestState.opened;
        }

        else if (Input == "lock")
        {
            current = ChestState.locked;
        }

    }
    


}




enum ChestState
{
    locked,
    unlocked,
    opened,
    closed
}