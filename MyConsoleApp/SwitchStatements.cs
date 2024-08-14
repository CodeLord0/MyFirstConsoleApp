/*using System;

namespace MyConsoleApp
{
    class SwitchStatements
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Getday(4));//prints and passws the value for daynum
            Console.ReadLine();
        }

        static string Getday(int daynum)// defines a method 
        {
            string dayname;

            switch (daynum)// takes variable as an arument to check
            {
                case 0:
                    dayname = "Sunday";
                    break;// ends the loop
                case 1:// if daynum is 0
                    dayname = "Monday";
                    break;
                case 2:
                    dayname = "Tuesday";
                    break;
                case 3:
                    dayname = "Wednesday";
                    break;
                case 4:
                    dayname = "Thursday";
                    break;
                case 5:
                    dayname = "Friday";
                    break;
                case 6:
                    dayname = "Saturday";
                    break;
                default:// equivalent of else. if no conditions are met
                    dayname = "invalid number";
                    break;
            }

            return dayname;// return the corresponding day
        }

    }
}*/