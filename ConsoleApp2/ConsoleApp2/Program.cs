// See https://aka.ms/new-console-template for more information
//int num = 12;






int Instead(int number)
{
    
    
    if(number == 0) return 1;

    else
    {
        Console.WriteLine(number);
        return Instead(number -1 );
    }
    
    
}

Instead(10);
