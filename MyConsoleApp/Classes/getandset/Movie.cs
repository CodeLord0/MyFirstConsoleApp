/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.Classes.getandset
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }// this gets rating 
            set { if (value == "G" || value == "PG" || value == "PG-13" || value == "R"){//checks if the rating for the movie object is a valid rating  
                    
                    rating = value; // value represents the value we are trying to assign

                }  
                else
                {
                        rating = "PG-13";//if rating is invalied set it to pg13
                }

                }
            }

        }

    }
*/