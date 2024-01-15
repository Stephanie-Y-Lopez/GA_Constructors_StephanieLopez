using System;
using System.Collections.Generic;
using System.Linq;
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
        private int pagecount;

        //Custom constructor 
        public Book(string booktitle, string author, int pagecount)
        {
            //Custom Constrcutors initalized fields
            this.title = title;
            this.author = author;
            this.pagecount = pagecount;

            //The purpose of creating custom constructors is, with limitations they allow for specific initialization of fields.
        }
    }
}
