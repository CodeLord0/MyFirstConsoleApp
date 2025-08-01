using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
Console.ForegroundColor = ConsoleColor.DarkYellow;
int ManticoreHealth = 10;
int CityHealth = 15;
int roundNumber = 1;
Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore? ");
string playerOneInput = Console.ReadLine();
int ManticoreDistance = Convert.ToInt32(playerOneInput);
Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Player 2, it is your turn.");
string PlayerTwoInput = Console.ReadLine();
int playerTwoGuess = Convert.ToInt32(PlayerTwoInput);

while (ManticoreHealth > 0 & CityHealth > 0)
{
    Compute();
    roundNumber++;
}
Console.WriteLine("you Win");


void Compute()
{
    if (roundNumber % 3 == 0 & roundNumber % 5 == 0)
    {
        CityHealth--;
        ManticoreHealth -= 10;
        Console.WriteLine($"STATUS: Round: {roundNumber}  City: {CityHealth} / 15  Manticore: {ManticoreHealth} / 10");
        Console.WriteLine("That was a direct hit");
        Console.WriteLine("The cannon is expected to deal 10 damage this round");
        Console.Write("Entered desired range: ");
        PlayerTwoInput = Console.ReadLine();
        playerTwoGuess = Convert.ToInt32(PlayerTwoInput);
    }

    else if (roundNumber % 3 != 0 & roundNumber % 5 != 0 & playerTwoGuess == ManticoreDistance)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        CityHealth--;
        ManticoreHealth--;
        Console.WriteLine($"STATUS: Round: {roundNumber}  City: {CityHealth} / 15  Manticore: {ManticoreHealth} / 10");
        Console.WriteLine("The cannon is expected to deal 1 damage this round");
        Console.WriteLine("Entered desired range: ");
        Console.WriteLine("That was a direct hit");
        PlayerTwoInput = Console.ReadLine();
        playerTwoGuess = Convert.ToInt32(PlayerTwoInput); 
    }



    else if (playerTwoGuess > ManticoreDistance & roundNumber % 3 == 0 || roundNumber % 5 == 0)
    {
        CityHealth--;
        ManticoreHealth -= 3;
        Console.WriteLine($"STATUS: Round: {roundNumber}  City: {CityHealth} / 15  Manticore: {ManticoreHealth} / 10");
        Console.WriteLine("The cannon is expected to deal 3 damage this round");
        Console.WriteLine("Entered desired range: ");
        Console.WriteLine("That round overshot the target");
        PlayerTwoInput = Console.ReadLine();
        playerTwoGuess = Convert.ToInt32(PlayerTwoInput);
    }
    else if (playerTwoGuess < ManticoreDistance & roundNumber % 3 == 0 || roundNumber % 5 == 0)
    {
        CityHealth --;
        ManticoreHealth -= 3;
        Console.WriteLine($"STATUS: Round: {roundNumber}  City: {CityHealth} / 15  Manticore: {ManticoreHealth} / 10");
        Console.WriteLine("The cannon is expected to deal 3 damage this round");
        Console.WriteLine("Entered desired range: ");
        Console.WriteLine("That round fell short of the target");
        PlayerTwoInput = Console.ReadLine();
        playerTwoGuess = Convert.ToInt32(PlayerTwoInput);
    }
}
