using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        // a constructor is a method that is called when an object is created
        // parameters can be passed in to constructors for argument to be passed in the object

        public Student(string aName, string aMajor, double agpa)
        {
            //the variables act as methods for each class created
            //the values should be passed into the object when its created
            name = aName;
            major = aMajor;
            gpa = agpa;
        }
        //object methods are used to get information about an object
        public bool Hashonors()
        {
            if (gpa >= 3.5)
            {
                return true;

            }
            return false;
        }
    }
}
