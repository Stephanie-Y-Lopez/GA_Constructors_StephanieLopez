using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GA_Constructors_StephanieLopez
{
    internal class Book
    {
        // A default constructor is provided if no constructor is defined. 
        // And its behavior is to initialize fields with default values such as for integers.

        //Fields
        private string title;
        private string author;

        //Custom constructor 
        public Book(string title, string author)
        {
            //Custom Constrcutors initalized fields
            this.title = title;
            this.author = author;
            //The purpose of creating custom constructors is, with limitations they allow for specific initialization of fields.
        }

        // Overload constructor
        public Book(string title)
        {
            this.title = title;
            this.author = "No Author Given"; // Default value
        }
        //When you overload constructors in classes, you provide multiple ways to initialize objects of that class. Each overloaded constructor can accept different parameters.
        //Initializing fields is a good pratice because it reminds us to check that the objects start with valid states in constructor.

    }
}
