
using System.Runtime.InteropServices;

string varFletching;
string varArrowhead;


System.Console.WriteLine("Enter a fletcher");
varFletching = Console.ReadLine();
Console.Clear();

System.Console.WriteLine("enter an arrowhead");
varArrowhead = Console.ReadLine();


Arrows UserArrow = new(varArrowhead, varFletching, 20);





