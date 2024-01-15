using System.Runtime.CompilerServices;

namespace GA_Constructors_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez 
        static void Main(string[] args)
        {
            // A constructor is, a special method used to initalize objects of a class.
            // A constructors role is, to set initial values and prepare an object for usage. 

            //Creating instance
            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("The Hobbit");

            //Displaying instance
            Console.WriteLine(book1);
            Console.WriteLine(book2);
        }
    }
}