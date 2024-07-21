using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Strings
    {
        static void Main(string[] args)
        {
            string phrase = "say hi";
            Console.WriteLine("Heloo World"); //this is the command to print something
            Console.WriteLine("Hello\nWorld!");// \n prints the text after it in a new line

            // string methods and properties
            // properties are used to acess data about a datatype or string etc e.g Length. while meathods give instructions to be performed
            //on a data type and are followed by a bracket e.g .ToUpper()
            Console.WriteLine(phrase.Length);// this is a property
            Console.WriteLine(phrase.ToUpper());//this is a method
            Console.WriteLine(phrase.Contains("hello"));//some methods can takeon argumets

            //indexing
            //individual elements of a string can be acessed from indidaual indexes
            Console.WriteLine(phrase[0]);//






            Console.ReadLine();




        }
    }
}
