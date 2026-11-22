using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

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

            StringBuilder mo =new StringBuilder();
            mo.Append("Book List");
            mo.Append(" - Updated");
            Console.WriteLine(mo.ToString());


            #endregion

        }
    }
}
