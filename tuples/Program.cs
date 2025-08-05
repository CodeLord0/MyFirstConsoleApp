
System.Console.WriteLine("             Menu");
System.Console.WriteLine("Ingredient:       Type:       Seasoning:");
System.Console.WriteLine("mushrooms         soup        spicy");
System.Console.WriteLine("chicken           stew        salty");
System.Console.WriteLine("carrots           gumbo       sweet");
System.Console.WriteLine("potatoes");


(Mainingredient, Type, Seasoning) food1 = (Mainingredient.mushrooms, Type.soup, Seasoning.spicy);

System.Console.WriteLine("enter an ingredient: ");
string IngredientInput = Console.ReadLine();

System.Console.WriteLine("enter a type: ");
string TypeInput= Console.ReadLine();

System.Console.WriteLine("enter a seasoning: ");
string SeasoningInput = Console.ReadLine();



//ingedient
if (Enum.IsDefined(typeof(Mainingredient), IngredientInput))
{
    food1.Item1 = (Mainingredient)Enum.Parse(typeof(Mainingredient), IngredientInput);
}
else
{
    Console.WriteLine("Invalid ingredient");
}

//seasoning
if (Enum.IsDefined(typeof(Seasoning), SeasoningInput))
{
    food1.Item3 = (Seasoning)Enum.Parse(typeof(Seasoning), SeasoningInput);
}
else
{
    Console.WriteLine("Invalid Seasonig");
}

//type
if (Enum.IsDefined(typeof(Type), TypeInput))
{
    food1.Item2 = (Type)Enum.Parse(typeof(Type), TypeInput);
}
else
{
    Console.WriteLine("Invalid type");
}
Console.WriteLine($"Your meal is {food1.Item1} {food1.Item2} {food1.Item3}");



enum Mainingredient
{
    mushrooms,
    chicken,
    carrots,
    potatoes
}

enum Type
{
    soup,
    stew,
    gumbo
}

enum Seasoning
{
    spicy,
    salty,
    sweet
}