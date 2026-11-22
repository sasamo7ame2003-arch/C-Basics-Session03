using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Basics_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            // Q1.Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            ////both title and upperTitle to show that title did not change.
            //string Title = "clean code";
            //string upperTitle= Title.ToUpper();
            // Console.WriteLine(Title);
            // Console.WriteLine(upperTitle);

            #endregion

            #region Question2
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            //to check if they point to the same object in memory.

            //string Titel1 = "clean code";

            //string Titel2 = "clean code";

            //Console.WriteLine(object.ReferenceEquals(Titel1,Titel2));



            #endregion

            #region  Question3

            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            // object.Print the final result.

            //StringBuilder mo =new StringBuilder();
            //mo.Append("Book List");
            //mo.Append(" - Updated");
            //Console.WriteLine(mo.ToString());


            #endregion

            #region Question4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            // Print the result.


            //StringBuilder mo = new StringBuilder("Book List");
            //mo.Replace("Book List", "Library");
            //mo.Append(" - Updated");
            //Console.WriteLine(mo.ToString());


            #endregion


            #region  Question5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            //Pages: 464" using the + operator

            //string Title = "Book Clean Code";
            //int Pages = 464;


            //  string Concat ="Title name:" + Title + "_" + Pages + "Pages";
            //Console.WriteLine(Concat);
            //Console.WriteLine($"Title name: {Title} _ {Pages} Pages");
            //Console.WriteLine("Title name: {0}_{1}Pages", Title, Pages);


            #endregion


            #region Question6
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            //300, otherwise prints "Short Book"

            //int Pages = 464;
            //if (Pages <300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //   Console.WriteLine("Short Book");
            //}
            #endregion

            #region Question7
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            //greater than 300 and isAvailable is true.Use the && operator.

            //int Pages = 464;
            //bool isAvailable =true;
            //if (Pages > 300 && isAvailable == true)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region Question8
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            //string Title = "Refactoring";


            //switch (Title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;

            //}


            #endregion

            #region Question9
            //int Pages = 464;

            //string sizeLabel = Pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);



            #endregion

            #region Question10

            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            // to print each book with its position number, like 1.Clean Code.


            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++) 
            //{
            //    Console.WriteLine(i  +  1 +"." + books[i]);
            //}


            #endregion


            #region Question11

            //Using the same books array, use a while loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while  (i < books.Length)
            //{
            //    Console.WriteLine(books[i]);
            //    i++;
            //}
            #endregion

            #region Question12
            //Write a do-while loop that prints "Checking book..." exactly 3 times.
            //int Counter = 0;
            //do
            //{

            //    Console.WriteLine("Checking book...");
            //    Counter++;
            //} while (Counter < 3);

            #endregion


            #region Question13
            //Using the same books array, use a foreach loop to print every book title.

            //string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string Book in Books)
            //{
            //    Console.WriteLine(Book);
            //}
            #endregion

            #region Question14
            //Using the same books array, loop through it and print each title, but stop completely (break) once
            //you reach "Refactoring".
            string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string Book in Books)
            {
                if (Book== "Refactoring")
                    break;
                Console.WriteLine(Book);
            }
          


                   
            
            #endregion
        }

    }
}

