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

            //Creating an instances using my custom constructor
            Book FavBook = new Book("Attack on Titan Volume 1", "Hajime Isayama", 208);

            //Displaying the initalized field
            Console.WriteLine($"Title: {FavBook.title}, Author: {FavBook.author}, Page Count: {FavBook.pagecount}");
        }
    }
}