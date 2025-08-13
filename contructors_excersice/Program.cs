// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Arrows
{
    //object variables
    // parameters are used as objects and there variables REPRESENT the parameters
    public float length;
    public Arrowhead arrowEnum;
    public Fletching fletchingEnum;


    public Arrows(string aArrowhead, string aFletching, int aLength)
    {
        arrowEnum = (Arrowhead)Enum.Parse(typeof(Arrowhead), aArrowhead); // converts the user's string into an Enum
        fletchingEnum = (Fletching)Enum.Parse(typeof(Fletching), aFletching);
        length = aLength;
        System.Console.WriteLine("object created");
    }

    public enum Arrowhead
    {
        wood,
        steel,
        obsidian
    }

    public enum Fletching
    {
        plastic,
        turkeyFeather,
        gooseFeather
    }

/// <summary>
/// This method calculates the gold value.
/// </summary>
    public void GetCost()
    {
        float gold = 0f;

        switch (arrowEnum)
        {
            case Arrowhead.wood:
                gold += 3f;
                break;

            case Arrowhead.steel:
                gold += 10f;
                break;

            case Arrowhead.obsidian:
                gold += 5f;
                break;

        }
        switch (fletchingEnum)
        {
            case Fletching.plastic:
                gold += 10f;
                break;

            case Fletching.turkeyFeather:
                gold += 5f;
                break;

            case Fletching.gooseFeather:
                gold += 3f;
                break;

        }

        //prints the gold value ;
        System.Console.WriteLine(gold + (length * 0.05f));


        // switch statemetn for fletching and length




    }
    
    
    
    

}
