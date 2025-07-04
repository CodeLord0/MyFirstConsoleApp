using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter target column: ");
            string targetColumn = Console.ReadLine();

            Console.Write("Enter target row: ");
            string targetRow = Console.ReadLine();
            Console.Clear();

            int squadtop_x = Convert.ToInt32(targetColumn);
            int squadtop_y = Convert.ToInt32(targetRow) + 1;
            
            int squadleft_x = Convert.ToInt32( targetColumn) - 1;
            int squadleft_y = Convert.ToInt32(targetRow);

            int squadright_x = Convert.ToInt32(targetColumn) + 1;
            int squadright_y = Convert.ToInt32(targetRow);

            int squadbottom_x = Convert.ToInt32(targetColumn);
            int squadbottom_y = Convert.ToInt32(targetRow) -1;

            Console.WriteLine($"Target row: {targetColumn}");
            Console.WriteLine($"Target column: {targetRow}");

            
            Console.WriteLine($"deploy to:");
            Console.WriteLine($"{squadtop_x},{squadtop_y}");
            Console.WriteLine($"{squadbottom_x},{squadbottom_y}");
            Console.WriteLine($"{squadright_x},{squadright_y}");
            Console.WriteLine($"{squadleft_x},{squadleft_y}");
            
            Console.Beep(400, 1000);
            Console.ReadLine();




           




        }

    }
}
